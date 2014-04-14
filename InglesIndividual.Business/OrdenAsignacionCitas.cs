using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Business
{
    public class OrdenAsignacionCitas : BaseBusinessObject
    {
        private Data.OrdenAsignacionCitas Data
        {
            get { return this.DataObject as Data.OrdenAsignacionCitas; }
        }

        public OrdenAsignacionCitas()
        {
            this.DataObject = new Data.OrdenAsignacionCitas();
        }

        public List<Entities.OrdenAsignacionCitas> ListarOrdenAsignacionCitas(InglesIndividual.Entities.JQXGridSettings settings, int ClaCampus)
        {
            return this.Data.ListarOrdenAsignacionCitas(settings, ClaCampus);
        }

        public List<Exception> Eliminar(int[] clas)
        {
            List<Exception> list = new List<Exception>();
            if (clas != null && clas.Length > 0)
            {
                foreach (int cla in clas)
                {
                    Entities.OrdenAsignacionCitas item = new Entities.OrdenAsignacionCitas(true);
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
