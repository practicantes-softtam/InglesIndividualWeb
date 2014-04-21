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

        public List<Entities.Ciudades> ListarCiudades(Entities.JQXGridSettings settings,int claCiudad, int claEstado, int claPais)
        {
            return this.Data.ListarCiudades(settings, claCiudad, claEstado, claPais);


        }
        public List<Exception> Eliminar(string[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (string id in ids)
                {
                    Entities.Ciudades item = new Entities.Ciudades(true);
                    item.ClaCiudad = Utils.IsNull(id, 0);

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
    }
}