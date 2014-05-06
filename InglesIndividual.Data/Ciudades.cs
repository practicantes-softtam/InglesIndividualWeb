using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;


namespace InglesIndividual.Data
{
    public class Ciudades : InglesIndividualDataObject
    {
        public List<Entities.Ciudad> ListarCiudades(InglesIndividual.Entities.JQXGridSettings settings, string nomCiudad)
        {
            List<Entities.Ciudad> list = new List<Entities.Ciudad>();
            DataEntities.SpCiudadesGrd sp = new DataEntities.SpCiudadesGrd();
            sp.NomCiudad = nomCiudad;
            this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
         {
                Entities.Ciudad item = new Entities.Ciudad(true);
                item.ID = Utils.GetDataRowValue(dr, "ClaCiudad", 0);
                item.Nombre = Utils.GetDataRowValue(dr, "NomCiudad", "");
                item.Estado = new Entities.Estado();
                item.Estado.ID = Utils.GetDataRowValue(dr, "ClaEstado", 0);
                item.Estado.Nombre = Utils.GetDataRowValue(dr, "NomEstado", "");
                item.Estado.Pais = new Entities.Pais();
                item.Estado.Pais.Nombre = Utils.GetDataRowValue(dr, "NomPais", "");
                item.Estado.Pais.ID = Utils.GetDataRowValue(dr, "ClaPais", 0);
                this.SetWebEntityGridValues(item, dr);
                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.Ciudad item = entity as Entities.Ciudad;
            DataEntities.SpCiudadesIns
            sp = new DataEntities.SpCiudadesIns();
            sp.ClaCiudad = item.ID;
            sp.ClaEstado = item.Estado.ID;
            sp.ClaPais = item.Estado.Pais.ID;
            
            if (tran !=null) {
            return sp.ExecuteNonQuery(tran);
                
            }
            else { 
            return sp.ExecuteNonQuery (this.ConnectionString);
            }
          }


        public override int Delete(Entity entity, DataTransaction tran)
        {
            Entities.Ciudad item = entity as Entities.Ciudad;
            DataEntities.SpCiudadesDel
                sp = new DataEntities.SpCiudadesDel();
            sp.NomCiudad = item.Nombre;
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
