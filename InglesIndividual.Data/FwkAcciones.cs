using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace InglesIndividual.Data
{

    public class FwkAcciones : InglesIndividualDataObject
    {
        public List<Entities.FwkAcciones> ListarFwkAcciones(InglesIndividual.Entities.JQXGridSettings settings,string claAccion, string descripcion)
        {
            List<Entities.FwkAcciones> list = new List<Entities.FwkAcciones>();
            DataEntities.SpFwkAccionesGrd sp = new DataEntities.SpFwkAccionesGrd();
            sp.ClaAccion = claAccion;
            sp.Descripcion = descripcion;
            this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.FwkAcciones item = new Entities.FwkAcciones(true);

                item.ClaAccion = Utils.GetDataRowValue(dr, "ClaAccion", ""); ;
                item.Descripcion = Utils.GetDataRowValue(dr, "Descripcion", "");

                this.SetWebEntityGridValues(item, dr);

                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.FwkAcciones item = entity as Entities.FwkAcciones;
            DataEntities.spFwkAccionesIns
               sp = new DataEntities.spFwkAccionesIns();
            sp.ClaAccion= item.ClaAccion;
            sp.Descripcion = item.Descripcion;

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
            Entities.FwkAcciones item = entity as Entities.FwkAcciones;
            DataEntities.spFwkAccionesDel
            sp = new DataEntities.spFwkAccionesDel();
            sp.ClaAccion= item.ClaAccion;


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