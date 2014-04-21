using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Business
{
    public class Encuestas : InglesIndividualBusinessObject
    {
        private Data.Encuestas Data
        {
            get { return this.DataObject as Data.Encuestas; }
        }

        public Encuestas()
        {
            this.DataObject = new Data.Encuestas();
        }

        public List<Entities.Encuestas> ListarEncuestas(InglesIndividual.Entities.JQXGridSettings settings, string nomEncuesta)
        {
            return this.Data.ListarEncuestas(settings, nomEncuesta);
        }

        public List<Exception> Eliminar(string[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (string id in ids)
                {
                    Entities.Encuestas item = new Entities.Encuestas(true);
                    item.ClaEncuesta = Utils.IsNull(id, 0);

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
