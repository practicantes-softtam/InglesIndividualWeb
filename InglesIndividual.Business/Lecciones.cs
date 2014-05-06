using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
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

        public List<Entities.Lecciones> ListarLecciones(InglesIndividual.Entities.JQXGridSettings settings, string NomLeccion,  int claLeccion, int claNivel, int esReview)
        {
            return this.Data.ListarLecciones(settings, NomLeccion, claLeccion, claNivel, esReview);
        }

        public List<Exception> Eliminar(string[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (string id in ids)
                {
                    Entities.Lecciones item = new Entities.Lecciones(true);
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
