﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Framework;

namespace InglesIndividual.Data
{
    public class Nivel : InglesIndividualDataObject
    {
        public List<Entities.Nivel> ListarNivel(Entities.JQXGridSettings settings, string NomNivel)
        {
            DataEntities.SpNivelesGrd sp = new DataEntities.SpNivelesGrd();
            List<Entities.Nivel> list = new List<Entities.Nivel>();
            sp.NomNivel = NomNivel;
            this.ConfigurePagedStoredProcedure(sp, settings);
            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.Nivel item = new Entities.Nivel(true);
                item.ID = Utils.GetDataRowValue(dr, "ClaNivel", 0);
                this.SetWebEntityGridValues(item, dr);
                list.Add(item);
            }
            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.Nivel item = entity as Entities.Nivel;
            DataEntities.SpNivelesIns sp = new DataEntities.SpNivelesIns();
            sp.ClaNivel = item.ID;
            sp.NomNivel = item.Nombre;
            sp.ClubConversacion = item.ClubConversacion;
          
                return sp.ExecuteNonQuery(this.ConnectionString);
            }


        public override int Delete(Entity entity, DataTransaction tran)
        {
            Entities.Nivel item = entity as Entities.Nivel;
            DataEntities.SpNivelesDel sp = new DataEntities.SpNivelesDel();
            sp.ClaNivel = item.ID;
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
            Entities.Nivel item = entity as Entities.Nivel;
            DataEntities.SpNivelesUpd sp = new DataEntities.SpNivelesUpd();
            sp.ClaNivel = item.ID;
            sp.NomNivel = item.Nombre;
            

            return sp.ExecuteNonQuery(this.ConnectionString);
        }

        public override void PrepareEntityForEdition(Entity entity)
        {
            Entities.Nivel item = entity as Entities.Nivel;
            if (item != null && item.FromDataSource)
            {
                DataEntities.SpNivelesSel sp = new DataEntities.SpNivelesSel();
                sp.ClNivel= item.ID;

                DataTable dt = sp.GetDataTable(this.ConnectionString);
                if (dt != null && dt.Rows.Count == 1)
                {
                    item.ID = Utils.GetDataRowValue(dt.Rows[0], "ClaNivel", 0);
                    item.Nombre = Utils.GetDataRowValue(dt.Rows[0], "NomNivel", "");
                }
            }
        }
    }
}
