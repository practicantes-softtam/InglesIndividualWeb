using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Business
{
    public class Lecciones : InglesIndividualBusinessObject
    {
        private Data.Lecciones Data
        {
            get { return this.DataObject as Data.Lecciones; }
        }

        public Lecciones()
        {
            this.DataObject = new Data.Lecciones();
        }

        public List<Entities.Lecciones> ListarLecciones(InglesIndividual.Entities.JQXGridSettings settings, int claLeccion, int ClaNivel)
        {
            return this.Data.ListarLecciones(settings, claLeccion, ClaNivel);
        }

        public List<Exception> Eliminar(int[] clas)
        {
            List<Exception> list = new List<Exception>();
            if (clas != null && clas.Length > 0)
            {
                foreach (int cla in clas)
                {
                    Entities.Lecciones item = new Entities.Lecciones(true);
                    item.ClaLeccion = Utils.IsNull(cla, 0);
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
