﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;


namespace InglesIndividual.Data
{
    public class Ciudades : InglesIndividualDataObject
    {
        public List<Entities.Ciudad> ListarCiudades(InglesIndividual.Entities.JQXGridSettings settings, string nomCiudad, int claEstado, int claPais)
        {
            List<Entities.Ciudad> list = new List<Entities.Ciudad>();
            DataEntities.SpCiudadesGrd sp = new DataEntities.SpCiudadesGrd();
            sp.NomCiudad = nomCiudad;
            sp.ClaEstado = claEstado;
            sp.ClaPais = claPais;
            this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
         {
                Entities.Ciudad item = new Entities.Ciudad(true);
                item.Clave = Utils.GetDataRowValue(dr, "ClaCiudad", 0);
                item.Nombre = Utils.GetDataRowValue(dr, "NomCiudad", "");
                item.Estado = new Entities.Estado();
                item.Estado.Nombre = Utils.GetDataRowValue(dr, "NomEstado", "");
                item.Estado.Pais = new Entities.Pais();
                item.Estado.Pais.Nombre = Utils.GetDataRowValue(dr, "NomPais", "");   
                
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
            sp.ClaCiudad = item.Clave;
            sp.ClaEstado = item.Estado.Clave;
            sp.ClaPais = item.Estado.Pais.Clave;
            
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
            sp.ClaCiudad = item.Clave;
            

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