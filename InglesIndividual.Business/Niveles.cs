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

        public List<Entities.Nivel> ListarNiveles(InglesIndividual.Entities.JQXGridSettings settings, int ClaNivel)
        {
            return this.Data.ListarNivel(settings, ClaNivel);
        }

        public List<Exception> Eliminar(int[] clas)
        {
            List<Exception> list = new List<Exception>();
            if (clas != null && clas.Length > 0)
            {
                foreach (int cla in clas)
                {
                    Entities.Nivel item = new Entities.Nivel(true);
                    item.ClaNivel = Utils.IsNull(cla, 0);

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
