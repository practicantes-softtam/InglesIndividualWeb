using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Business
{
    public class Niveles : BaseBusinessObject
    {
        private Data.Niveles Data
        {
            get { return this.DataObject as Data.Niveles; }
        }

        public Niveles()
        {
            this.DataObject = new Data.Niveles();
        }

        public List<Entities.Nivel> ListarNiveles(InglesIndividual.Entities.JQXGridSettings settings, string nomNivel)
        {
            return this.Data.ListarNivel(settings, nomNivel);
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

        public List<Entities.Nivel> Combo(int claPais)
        {
            return this.Data.Combo(claPais);
        }

    }
}
