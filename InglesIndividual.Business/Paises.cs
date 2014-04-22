using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;


namespace InglesIndividual.Business
{
    public class Paises:InglesIndividualBusinessObject
    {
         private Data.Paises Data
        {
            get { return this.DataObject as Data.Paises; }
        }

        public Paises()
        {
            this.DataObject = new Data.Paises();
        }

        public List<Entities.Pais> ListarPaises(InglesIndividual.Entities.JQXGridSettings settings, string nomPais)
        {
            return this.Data.ListarPaises(settings, nomPais);
        }

        public List<Exception> Eliminar(string[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (string id in ids)
                {
                    Entities.Pais item = new Entities.Pais(true);
                    item.Clave = Utils.IsNull(id, 0);

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
