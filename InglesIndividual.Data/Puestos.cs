using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace InglesIndividual.Data
{
    public class Puestos : InglesIndividualDataObject
    {
        public List<Entities.Puestos> ListarPuestos(InglesIndividual.Entities.JQXGridSettings settings, string nomPuesto)
        {
            List<Entities.Puestos> list = new List<Entities.Puestos>();
            DataEntities.SpPuestosGrd sp = new DataEntities.SpPuestosGrd();
            sp.NomPuesto = nomPuesto;
            this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.Puestos item = new Entities.Puestos(true);
                item.ClaPuesto = Utils.GetDataRowValue(dr, "ClaPuesto", 0);
                item.NomPuesto = Utils.GetDataRowValue(dr, "NomPuesto", "");
                
                this.SetWebEntityGridValues(item, dr);
                
                list.Add(item);
            }

            return list;
        }

        //public override int Insert(Entity entity, DataTransaction tran)
        //{
        //    Entities.FwkModulos item = entity as Entities.FwkModulos;
        //    DataEntities.SpFwkModulosIns
        //       sp = new DataEntities.SpFwkModulosIns();
        //    sp.ClaAplicaion = item.ClaAplicacion;
        //    sp.ClaModulo = item.ClaModulo;
        //    sp.NomModulo = item.NomModulo;
        //    sp.ClaModuloPadre = item.ClaModuloPadre;

        //    if (tran != null)
        //    {
        //        return sp.ExecuteNonQuery(tran);
        //    }
        //    else
        //    {
        //        return sp.ExecuteNonQuery(this.ConnectionString);
        //    }

        //}

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.Puestos item = entity as Entities.Puestos;
            DataEntities.SpPuestosIns sp = new DataEntities.SpPuestosIns();
            sp.ClaPuesto = item.ClaPuesto;
            sp.NomPuesto = item.NomPuesto;

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
            Entities.Puestos item = entity as Entities.Puestos;
            DataEntities.SpPuestosDel sp = new DataEntities.SpPuestosDel();
            sp.ClaPuesto = item.ClaPuesto;

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
