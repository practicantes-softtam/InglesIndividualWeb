using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Business
{
    public class Salones : InglesIndividualBusinessObject
    {
        private Data.Salones Data
        {
            get { return this.DataObject as Data.Salones; }
        }

        public Salones()
        {
            this.DataObject = new Data.Salones();
        }

        public List<Entities.Salones> ListarSalones(InglesIndividual.Entities.JQXGridSettings settings, int IdSalon)
        {
            return this.Data.ListarSalones(settings, IdSalon);
        }

        public List<Exception> Eliminar(int[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (int id in ids)
                {
                    Entities.Salones item = new Entities.Salones(true);
                    item.IdSalon = Utils.IsNull(id, 0);

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
