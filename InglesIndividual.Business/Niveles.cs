using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Business
{
    public class Niveles : BaseBusinessObject
    {
        private Data.Nivel Data
        {
            get { return this.DataObject as Data.Nivel; }
        }

        public Niveles()
        {
            this.DataObject = new Data.Nivel();
        }

        public List<Entities.Nivel> ListarNiveles(InglesIndividual.Entities.JQXGridSettings settings, string NomNivel)
        {
            return this.Data.ListarNivel(settings, NomNivel);
        }

        public List<Exception> Eliminar(string[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (string id in ids)
                {
                    Entities.Nivel item = new Entities.Nivel(true);
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

    }
}
