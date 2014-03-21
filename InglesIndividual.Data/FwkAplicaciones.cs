using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace InglesIndividual.Data
{

    public class FwkAplicaciones : InglesIndividualDataObject
    {
        public List<Entities.FwkAplicaciones> ListarPaises(InglesIndividual.Entities.JQXGridSettings settings, string nomAplicaciones)
        {
            List<Entities.FwkAplicaciones> list = new List<Entities.FwkAplicaciones>();
            DataEntities.SpFwkAplicacionesGrd sp = new DataEntities.SpFwkAplicacionesGrd();
            sp.NomAplicacion = nomAplicaciones;
            this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.FwkAplicaciones item = new Entities.FwkAplicaciones(true);

                item.ClaAplicacion = Utils.GetDataRowValue(dr, "ClaAplicacion", 0);
                item.NomAplicacion = Utils.GetDataRowValue(dr, "NomAplicacion", "");

                this.SetWebEntityGridValues(item, dr);

                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.FwkAplicaciones item = entity as Entities.FwkAplicaciones;
            DataEntities.SpFwkAplicacionesIns
               sp = new DataEntities.SpFwkAplicacionesIns();
            sp.ClaAplicaion = item.ClaAplicacion;
            sp.NomAplicacion = item.NomAplicacion;

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
            Entities.FwkAplicaciones item = entity as Entities.FwkAplicaciones;
            DataEntities.SpFwkAplicacionesDel
               sp = new DataEntities.SpFwkAplicacionesDel();
            sp.ClaAplicacion = item.ClaAplicacion;
            


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
