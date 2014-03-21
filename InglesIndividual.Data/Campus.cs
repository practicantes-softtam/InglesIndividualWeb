using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Framework;

namespace InglesIndividual.Data
{
    public class Campus : InglesIndividualDataObject
    {
        public List<Entities.Campus> ListarCampus(Entities.JQXGridSettings settings, string nombre, int pais, int ciudad, int estado)
        {
            DataEntities.SpCampusGrd sp = new DataEntities.SpCampusGrd();
            List<Entities.Campus> list = new List<Entities.Campus>();

            sp.ClaCiudad = ciudad;
            sp.ClaEstado = estado;
            sp.ClaPais = pais;
            sp.NomCampus = nombre;
            this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);

            foreach (DataRow dr in dt.Rows)
            {
                Entities.Campus item = new Entities.Campus(true);
                item.Calle = Utils.GetDataRowValue(dr, "Calle", "");
                item.Ciudad = new Entities.Ciudad(true);
                item.Ciudad.Nombre = Utils.GetDataRowValue(dr, "NomCiudad", "");
                item.Clave = Utils.GetDataRowValue(dr, "ClaCampus", 0);
                item.CodigoPostal = Utils.GetDataRowValue(dr, "CodigoPostal", 0);
                item.Colonia = Utils.GetDataRowValue(dr, "Colonia", "");
                item.DirectorGeneral = Utils.GetDataRowValue(dr, "DirectorGeneral", "");
                item.Nombre = Utils.GetDataRowValue(dr, "NomCampus", "");
                item.Telefono = Utils.GetDataRowValue(dr, "Telefono", "");
                
                this.SetWebEntityGridValues(item, dr);

                list.Add(item);
            }

            return list;
        }
    }
}
