
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace InglesIndividual.Data
{
    public class Salones : InglesIndividualDataObject
    {

        public List<Entities.Salones> ListarSalones(InglesIndividual.Entities.JQXGridSettings settings, string nomSalon)
        {
            List<Entities.Salones> list = new List<Entities.Salones>();
            DataEntities.SpSalonesGrd sp = new DataEntities.SpSalonesGrd();
            sp.NomSalon = nomSalon;

            this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.Salones item = new Entities.Salones(true);

                item.ID = Utils.GetDataRowValue(dr, "IdSalon", 0);
                item.Campus = new Entities.Campus();
                item.Campus.ID = Utils.GetDataRowValue(dr, "ClaCampus", 0);
                item.Nombre = Utils.GetDataRowValue(dr, "NomSalon", "");
                item.Capacidad = Utils.GetDataRowValue(dr, "Capacidad", 0);
                
                this.SetWebEntityGridValues(item, dr);

                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.Salones item = entity as Entities.Salones;
            DataEntities.SpSalonesIns sp = new DataEntities.SpSalonesIns();
            sp.IdSalon = item.ID;
            sp.ClaCampus = item.Campus.ID;
            sp.NomSalon = item.Nombre;
            sp.Capacidad = item.Capacidad;

                return sp.ExecuteNonQuery(this.ConnectionString);
         }
        
        public override int Delete(Entity entity, DataTransaction tran)
        {
            Entities.Salones item = entity as Entities.Salones;
            DataEntities.SpSalonesDel
                sp = new DataEntities.SpSalonesDel();
            sp.IdSalon = item.ID;

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
            Entities.Salones item = entity as Entities.Salones;
            DataEntities.SpSalonesUpd sp = new DataEntities.SpSalonesUpd();
            sp.IdSalon = item.ID;
            sp.NomSalon= item.Nombre;
            sp.ClaCampus = item.Campus.ID;
            sp.Capacidad = item.Capacidad;

            return sp.ExecuteNonQuery(this.ConnectionString);
        }

        public override void PrepareEntityForEdition(Entity entity)
        {
            Entities.Salones item = entity as Entities.Salones;
            if (item != null && item.FromDataSource)
            {
                DataEntities.SpSalonesSel sp = new DataEntities.SpSalonesSel();
                sp.IdSalon = item.ID;

                DataTable dt = sp.GetDataTable(this.ConnectionString);
                if (dt != null && dt.Rows.Count == 1)
                {
                    item.ID = Utils.GetDataRowValue(dt.Rows[0], "IdSalon", 0);
                    item.Nombre = Utils.GetDataRowValue(dt.Rows[0], "NomSalon", "");
                }
            }
        }
    }
}
