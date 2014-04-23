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

        public List<Entities.Campus> ListarCampus(Entities.JQXGridSettings settings, string nomCampus)
        {
            return this.Data.ListarCampus(settings, nomCampus);
        }

        public List<Exception> Eliminar(string[] clas)
        {
            List<Exception> list = new List<Exception>();
            if (clas != null && clas.Length > 0)
            {
                foreach (string cla in clas)
                {
                    Entities.Campus item = new Entities.Campus(true);
                    item.NomCampus = Utils.IsNull(cla, "");

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
