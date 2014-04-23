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
        public List<Entities.Ciudades> ListarCiudades(InglesIndividual.Entities.JQXGridSettings settings, string nomCiudad)
        {
            List<Entities.Ciudades> list = new List<Entities.Ciudades>();
            DataEntities.SpCiudadesGrd sp = new DataEntities.SpCiudadesGrd();
            sp.NomCiudad = nomCiudad;
            this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
         {
                Entities.Ciudades item = new Entities.Ciudades(true);
                item.ClaCiudad = Utils.GetDataRowValue(dr, "ClaCiudad", 0);
                item.ClaEstado.Nombre = Utils.GetDataRowValue(dr, "ClaEstado", "");
                item.ClaEstado = new Entities.Estado();
                item.ClaPais.Nombre = Utils.GetDataRowValue(dr, "ClaPais", "");
                item.ClaPais = new Entities.Pais();
                this.SetWebEntityGridValues(item, dr);
                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.Ciudades item = entity as Entities.Ciudades;
            DataEntities.SpCiudadesIns
            sp = new DataEntities.SpCiudadesIns();
            sp.ClaCiudad = item.ClaCiudad;
            sp.ClaEstado = item.ClaEstado.Clave;
            sp.ClaPais = item.ClaPais.Clave;
            
            if (tran !=null) {
            return sp.ExecuteNonQuery(tran);
                
            }
            else { 
            return sp.ExecuteNonQuery (this.ConnectionString);
            }
          }


        public override int Delete(Entity entity, DataTransaction tran)
        {
            Entities.Ciudades item = entity as Entities.Ciudades;
            DataEntities.SpCiudadesDel
                sp = new DataEntities.SpCiudadesDel();
            sp.NomCiudad = item.NomCiudad;
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
