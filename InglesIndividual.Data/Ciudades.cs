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
        public List<Entities.Ciudad> ListarCiudades(InglesIndividual.Entities.JQXGridSettings settings, string nomCiudad, int claEstado, int claPais) //, int claEstado, int claPais
        {
            List<Entities.Ciudad> list = new List<Entities.Ciudad>();
            DataEntities.SpCiudadesGrd sp = new DataEntities.SpCiudadesGrd();
            sp.NomCiudad = nomCiudad;
            sp.ClaPais = claPais;
            sp.ClaEstado = claEstado;

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
                
                item.Pais = new Entities.Pais();
                item.Pais.Nombre = Utils.GetDataRowValue(dr, "NomPais", "");
                item.Pais.ID = Utils.GetDataRowValue(dr, "ClaPais", 0);
                
                this.SetWebEntityGridValues(item, dr);
                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.Ciudad item = entity as Entities.Ciudad;            
            DataEntities.SpCiudadesIns sp = new DataEntities.SpCiudadesIns();
            
            sp.ClaCiudad = item.ID;
            sp.NomCiudad = item.Nombre;
            sp.ClaEstado = item.Estado.ID;
            sp.ClaPais = item.Pais.ID;
            
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
            Entities.Ciudad item = entity as Entities.Ciudad;
            DataEntities.SpCiudadesDel 
            sp = new DataEntities.SpCiudadesDel();
            sp.ClaCiudad = item.ID;

            if (tran != null)
            {
                return sp.ExecuteNonQuery(tran);
            }
            else
            {
                return sp.ExecuteNonQuery(this.ConnectionString);
            }

        }

        public override int Update(Entity entity, DataTransaction tran)
        {
            Entities.Ciudad item = entity as Entities.Ciudad;
            DataEntities.SpCiudadesUpd sp = new DataEntities.SpCiudadesUpd();
            sp.ClaCiudad = item.ID;
            sp.ClaEstado = item.ID;
            sp.ClaPais = item.ID;
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

        public override void PrepareEntityForEdition(Entity entity)
        {
            Entities.Ciudad item = entity as Entities.Ciudad;
            if (item != null && item.FromDataSource)
            {
                DataEntities.SpCiudadesSel sp = new DataEntities.SpCiudadesSel();
                sp.ClaCiudad = item.ID;
                sp.ClaEstado = item.ID;
                sp.ClaPais = item.ID;

                DataTable dt = sp.GetDataTable(this.ConnectionString);
                if (dt != null && dt.Rows.Count == 1)
                {
                    item.ID = Utils.GetDataRowValue(dt.Rows[0], "ClaCiudad", 0);
                    item.ID = Utils.GetDataRowValue(dt.Rows[0], "ClaEstado", 0);
                    item.ID = Utils.GetDataRowValue(dt.Rows[0], "ClaPais", 0);
                    item.Nombre = Utils.GetDataRowValue(dt.Rows[0], "NomCiudad", "");

                }
            }
        }

        
        public List<Entities.Ciudad> Combo()
        {
            List<Entities.Ciudad> list = new List<Entities.Ciudad>();
            DataEntities.SpCiudadesSel sp = new DataEntities.SpCiudadesSel();
            sp.ClaPais = -1;
            sp.ClaEstado = -1;
            sp.ClaCiudad = -1;
            DataTable dt = sp.GetDataTable(this.ConnectionString);

            foreach (DataRow dr in dt.Rows)
            {
                Entities.Ciudad item = new Entities.Ciudad(true);
                item.ID = Utils.GetDataRowValue(dr, "ClaCiudad", 0);
                item.Nombre = Utils.GetDataRowValue(dr, "NomCiudad", "");

                this.SetWebEntityGridValues(item, dr);

                list.Add(item);
            }

            return list;
        }
    }
}
