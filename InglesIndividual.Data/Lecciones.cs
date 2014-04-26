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
        public List<Entities.Lecciones> ListarLecciones(Entities.JQXGridSettings settings, string NomLeccion)
        {
            List<Entities.Lecciones> list = new List<Entities.Lecciones>();
            DataEntities.SpLeccionesGrd sp = new DataEntities.SpLeccionesGrd();
            sp.NomLeccion = NomLeccion;
            this.ConfigurePagedStoredProcedure(sp, settings);
         
       
            this.ConfigurePagedStoredProcedure(sp, settings);
            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.Lecciones item = new Entities.Lecciones(true);
                item.Clave = Utils.GetDataRowValue(dr, "ClaLeccion", 0);
                item.Nombre = Utils.GetDataRowValue(dr, "NomLeccion", "");
                this.SetWebEntityGridValues(item, dr);
                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.Lecciones item = entity as Entities.Lecciones;
            DataEntities.SpLeccionesIns sp = new DataEntities.SpLeccionesIns();
            sp.ClaLeccion = item.Clave;
            sp.NomLeccion = item.Nombre;
            return sp.ExecuteNonQuery(this.ConnectionString);
        }
            
            
        public override int Delete(Entity entity, DataTransaction tran)
        {
            Entities.Lecciones item = entity as Entities.Lecciones;
            DataEntities.SpLeccionesDel sp = new DataEntities.SpLeccionesDel();
            sp.NomLeccion = item.Nombre;
            sp.ClaLeccion = item.Clave;
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
