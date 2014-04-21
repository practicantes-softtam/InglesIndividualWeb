using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Business
{
    public class Campus : BaseBusinessObject
    {
        private Data.Campus Data
        {
            get { return this.DataObject as Data.Campus; }
        }

        public Campus()
        {
            this.DataObject = new Data.Campus();
        }

        public List<Entities.Campus> ListarCampus(Entities.JQXGridSettings settings, int ClaCampus)
        {
            return this.Data.ListarCampus(settings, ClaCampus);
        }

        public List<Exception> Eliminar(int[] clas)
        {
            List<Exception> list = new List<Exception>();
            if (clas != null && clas.Length > 0)
            {
                foreach (int cla in clas)
                {
                    Entities.Campus item = new Entities.Campus(true);
                    item.ClaCampus = Utils.IsNull(cla, 0);

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
