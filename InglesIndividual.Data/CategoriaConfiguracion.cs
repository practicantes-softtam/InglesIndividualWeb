﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace InglesIndividual.Data
{
    public class CategoriaConfiguracion : InglesIndividualDataObject
    {
        public List<Entities.CategoriaConfiguracion> ListarCategoriaConfiguracion(InglesIndividual.Entities.JQXGridSettings settings, string nomCategoria)
        {
            List<Entities.CategoriaConfiguracion> list = new List<Entities.CategoriaConfiguracion>();
            DataEntities.SpCategoriaConfiguracionGrd sp = new DataEntities.SpCategoriaConfiguracionGrd();
            sp.NomCategoria = nomCategoria;

            this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.CategoriaConfiguracion item = new Entities.CategoriaConfiguracion(true);

                item.ClaCategoria = Utils.GetDataRowValue(dr, "ClaCategoria", 0);
                item.Nombre = Utils.GetDataRowValue(dr, "NomCategoria", "");


                this.SetWebEntityGridValues(item, dr);

                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.CategoriaConfiguracion item = entity as Entities.CategoriaConfiguracion;
            DataEntities.SpCategoriaConfiguracionIns
                sp = new DataEntities.SpCategoriaConfiguracionIns();
            sp.ClaCategoria = item.ClaCategoria;
            sp.NomCategoria = item.Nombre;


          //  if (tran != null)
          //  {
           //     return sp.ExecuteNonQuery(tran);

           // }
           // else
           // {
                return sp.ExecuteNonQuery(this.ConnectionString);
           // }
        }

        public override int Delete(Entity entity, DataTransaction tran)
        {
            Entities.CategoriaConfiguracion item = entity as Entities.CategoriaConfiguracion;
            DataEntities.SpCategoriaConfiguracionDel
                sp = new DataEntities.SpCategoriaConfiguracionDel();
            sp.ClaCategoria = item.ClaCategoria;

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
            Entities.CategoriaConfiguracion item = entity as Entities.CategoriaConfiguracion;
            DataEntities.SpCategoriaConfiguracionUpd sp = new DataEntities.SpCategoriaConfiguracionUpd();
            sp.ClaCategoria = item.ClaCategoria;
            sp.NomCategoria = item.Nombre;

            return sp.ExecuteNonQuery(this.ConnectionString);
        }

        public override void PrepareEntityForEdition(Entity entity)
        {
            Entities.CategoriaConfiguracion item = entity as Entities.CategoriaConfiguracion;
            if (item != null && item.FromDataSource)
            {
                DataEntities.SpCategoriaConfiguracionSel sp = new DataEntities.SpCategoriaConfiguracionSel();
                sp.ClaCategoria = item.ClaCategoria;

                DataTable dt = sp.GetDataTable(this.ConnectionString);
                if (dt != null && dt.Rows.Count == 1)
                {

                    item.ClaCategoria = Utils.GetDataRowValue(dt.Rows[0], "ClaCategoria", 0);
                    item.Nombre = Utils.GetDataRowValue(dt.Rows[0], "NomCategoria", "");
                }
            }
        }
    }
}
