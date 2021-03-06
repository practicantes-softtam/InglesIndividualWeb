﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace InglesIndividual.Data
{

    public class FwkModulos : InglesIndividualDataObject
    {
        public List<Entities.FwkModulos> ListarFwkModulos(InglesIndividual.Entities.JQXGridSettings settings, int claAplicacion, int ClaModulo, string nomModulo, int claModuloPadre)
        {
            List<Entities.FwkModulos> list = new List<Entities.FwkModulos>();
            DataEntities.SpFwkModulosGrd sp = new DataEntities.SpFwkModulosGrd();
            sp.ClaAplicaion = claAplicacion;
            sp.ClaModulo = ClaModulo;
            sp.NomModulo = nomModulo;
            sp.ClaModuloPadre = claModuloPadre;
            this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.FwkModulos item = new Entities.FwkModulos(true);
                item.FwkAplicaciones = new Entities.FwkAplicaciones();
                item.FwkAplicaciones.ClaAplicacion = Utils.GetDataRowValue(dr, "ClaAplicacion", 0);
                item.ClaModulo= Utils.GetDataRowValue(dr, "ClaModulo", 0);
                item.NomModulo = Utils.GetDataRowValue(dr, "NomModulo", "");
                item.ClaModuloPadre = Utils.GetDataRowValue(dr, "ClaModuloPadre", 0);

                this.SetWebEntityGridValues(item, dr);

                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.FwkModulos item = entity as Entities.FwkModulos;
            DataEntities.SpFwkModulosIns
            sp = new DataEntities.SpFwkModulosIns();
            sp.ClaAplicaion = item.FwkAplicaciones.ClaAplicacion;
            sp.ClaModulo = item.ClaModulo;
            sp.NomModulo = item.NomModulo;
            sp.ClaModuloPadre = item.ClaModuloPadre;

            if (tran != null)
            {
                return sp.ExecuteNonQuery(tran);
            }
            else
            {
                return sp.ExecuteNonQuery(this.ConnectionString);
            }
        }

        

        public override int Delete(Entity entity, DataTransaction tran)
        {
            Entities.FwkModulos item = entity as Entities.FwkModulos;
            DataEntities.SpFwkModulosDel
               sp = new DataEntities.SpFwkModulosDel();
            sp.ClaAplicaion = item.FwkAplicaciones.ClaAplicacion;
            sp.ClaModulo = item.ClaModulo;
            

            if (tran != null)
            {
                return sp.ExecuteNonQuery(tran);
            }
            else
            {
                return sp.ExecuteNonQuery(this.ConnectionString);
            }

        }




    }
}
