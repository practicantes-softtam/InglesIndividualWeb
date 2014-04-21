using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Framework;

namespace InglesIndividual.Data
{
    public class Lecciones : InglesIndividualDataObject
    {
        public List<Entities.Lecciones> ListarLecciones(Entities.JQXGridSettings settings, int ClaLeccion)
        {
            DataEntities.SpLeccionesGrd sp = new DataEntities.SpLeccionesGrd();
            List<Entities.Lecciones> list = new List<Entities.Lecciones>();
            sp.ClaLeccion = ClaLeccion;
            this.ConfigurePagedStoredProcedure(sp, settings);
            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.Lecciones item = new Entities.Lecciones(true);
                item.ClaLeccion = Utils.GetDataRowValue(dr, "CLaLeccion", 0);
                item.ClaNivel = Utils.GetDataRowValue(dr, "ClaNivel", 0);
                this.SetWebEntityGridValues(item, dr);
                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.Lecciones item = entity as Entities.Lecciones;
            DataEntities.SpLeccionesIns sp = new DataEntities.SpLeccionesIns();
            sp.ClaLeccion = item.ClaLeccion;
            sp.ClaNivel = item.ClaNivel;
            sp.NomLeccion = item.NomLeccion;
            sp.EsReview = item.EsReview;
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
            Entities.Lecciones item = entity as Entities.Lecciones;
            DataEntities.SpLeccionesDel sp = new DataEntities.SpLeccionesDel();
            sp.ClaLeccion = item.ClaLeccion;
            sp.ClaNivel = item.ClaNivel;
            if (tran != null)
            {
                return sp.ExecuteNonQuery(tran);
            }
            else
            {
                return sp.ExecuteNonQuery (this.ConnectionString);
            }
        }

    }
}
