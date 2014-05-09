using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Business
{
    public class Ciudades : InglesIndividualBusinessObject
    {
        private Data.Ciudades Data
        {
            get { return this.DataObject as Data.Ciudades; }
        }

        public Ciudades()
        {
            this.DataObject = new Data.Ciudades();
        }

        public List<Entities.Ciudad> ListarCiudades( InglesIndividual.Entities.JQXGridSettings settings, int claEstado, int claPais, string nomCiudad)
        {
            return this.Data.ListarCiudades(settings, claEstado, claPais, nomCiudad);


        }
        public List<Exception> Eliminar(string[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (string id in ids)
                {
                    Entities.Ciudad item = new Entities.Ciudad(true);
                    item.ID = Utils.IsNull(id, 0);

                    try
                    {
                        this.Data.Delete(item);
                    }
                    catch (Exception ex)
                    {
                        list.Add(ex);
                    }
                }
            }

            return list;
        }

        public List<Entities.Ciudad> Combo()
        {
            return this.Data.Combo();
        }
    }
}