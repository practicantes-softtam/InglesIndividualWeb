using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Framework;

namespace InglesIndividual.Data
{
    public class OrdenAsignacionCitas : InglesIndividualDataObject
    {
        public List<Entities.OrdenAsignacionCitas> ListarOrdenAsignacionCitas(Entities.JQXGridSettings settings, int ClaCampus)
        {
            DataEntities.SpOrdenAsignacionCitasGrd sp = new DataEntities.SpOrdenAsignacionCitasGrd();
            List<Entities.OrdenAsignacionCitas> list = new List<Entities.OrdenAsignacionCitas>();
            sp.ClaCampus = ClaCampus;
            this.ConfigurePagedStoredProcedure(sp, settings);
            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.OrdenAsignacionCitas item = new Entities.OrdenAsignacionCitas(true);
                item.ClaCampus = Utils.GetDataRowValue(dr, "ClaCampus", 0);
                item.ClaProfesor = Utils.GetDataRowValue(dr, "ClaProfesor", 0);
                item.Orden = Utils.GetDataRowValue(dr, "Orden", 0);
                this.SetWebEntityGridValues(item, dr);
                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.OrdenAsignacionCitas item = entity as Entities.OrdenAsignacionCitas;
            DataEntities.SpOrdenAsignacionCitasIns sp = new DataEntities.SpOrdenAsignacionCitasIns();
            sp.ClaCampus = item.ClaCampus;
            sp.ClaProfesor = item.ClaProfesor;
            sp.Orden = item.Orden;
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
            Entities.OrdenAsignacionCitas item = entity as Entities.OrdenAsignacionCitas;
            DataEntities.SpOrdenAsignacionCitasDel sp = new DataEntities.SpOrdenAsignacionCitasDel();
            sp.ClaCampus = item.ClaCampus;

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

