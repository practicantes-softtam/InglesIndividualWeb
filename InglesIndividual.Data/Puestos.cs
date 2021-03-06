﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace InglesIndividual.Data
{
    public class Puestos : InglesIndividualDataObject
    {
        public List<Entities.Puesto> ListarPuestos(InglesIndividual.Entities.JQXGridSettings settings, string nomPuesto)
        {
            List<Entities.Puesto> list = new List<Entities.Puesto>();
            DataEntities.SpPuestosGrd sp = new DataEntities.SpPuestosGrd();
            sp.NomPuesto = nomPuesto;
            this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.Puesto item = new Entities.Puesto(true);
                item.ID = Utils.GetDataRowValue(dr, "ClaPuesto", 0);
                item.Nombre = Utils.GetDataRowValue(dr, "NomPuesto", "");

                this.SetWebEntityGridValues(item, dr);

                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity)
        {
            Entities.Puesto item = entity as Entities.Puesto;
            DataEntities.SpPuestosIns sp = new DataEntities.SpPuestosIns();
            sp.ClaPuesto = item.ID;
            sp.NomPuesto = item.Nombre;

            return sp.ExecuteNonQuery(this.ConnectionString);
        }

        public override int Delete(Entity entity, DataTransaction tran)
        {
            Entities.Puesto item = entity as Entities.Puesto;
            DataEntities.SpPuestosDel sp = new DataEntities.SpPuestosDel();
            sp.ClaPuesto = item.ID;

            if (tran != null)
            {
                return sp.ExecuteNonQuery(tran);
            }
            else
            {
                return sp.ExecuteNonQuery(this.ConnectionString);
            }
        }

        public override int Update(Entity entity)
        {
            Entities.Puesto item = entity as Entities.Puesto;
            DataEntities.SpPuestosUpd sp = new DataEntities.SpPuestosUpd();
            sp.ClaPuesto = item.ID;
            sp.NomPuesto = item.Nombre;

            return sp.ExecuteNonQuery(this.ConnectionString);
        }

        public override void PrepareEntityForEdition(Entity entity)
        {
            Entities.Puesto item = entity as Entities.Puesto;
            if (item != null && item.FromDataSource)
            {
                DataEntities.SpPuestosSel sp = new DataEntities.SpPuestosSel();
                sp.ClaPuesto = item.ID;

                DataTable dt = sp.GetDataTable(this.ConnectionString);
                if (dt != null && dt.Rows.Count == 1)
                {
                    item.ID = Utils.GetDataRowValue(dt.Rows[0], "ClaPuesto", 0);
                    item.Nombre = Utils.GetDataRowValue(dt.Rows[0], "NomPuesto", "");
                }
            }
        }

        public List<Entities.Puesto> Combo()
        {
            List<Entities.Puesto> list = new List<Entities.Puesto>();
            DataEntities.SpPuestosSel sp = new DataEntities.SpPuestosSel();
            sp.ClaPuesto = -1;
            DataTable dt = sp.GetDataTable(this.ConnectionString);

            foreach (DataRow dr in dt.Rows)
            {
                Entities.Puesto item = new Entities.Puesto(true);
                item.ID = Utils.GetDataRowValue(dr, "ClaPuesto", 0);
                item.Nombre = Utils.GetDataRowValue(dr, "NomPuesto", "");

                this.SetWebEntityGridValues(item, dr);

                list.Add(item);
            }

            return list;
        }
    }
}
