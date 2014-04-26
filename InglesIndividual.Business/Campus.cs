using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Business
{
    public class Campus : InglesIndividualBusinessObject
    {
        private Data.Campus Data
        {
            get { return this.DataObject as Data.Campus; }
        }

        public Campus()
        {
            this.DataObject = new Data.Campus();
        }

        public List<Entities.Campus> ListarCampus(InglesIndividual.Entities.JQXGridSettings settings, string nomCampus, string calle, string colonia, string telefono)
        {
            return this.Data.ListarCampus(settings, nomCampus, calle, colonia, telefono);//this.Data.ListarCampus(settings, nomCampus, calle, colonia, telefono);
        }

        public List<Exception> Eliminar(string[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (string id in ids)
                {
                    Entities.Campus item = new Entities.Campus(true);
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
