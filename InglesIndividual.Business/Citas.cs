using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Business
{
    public class Citas : InglesIndividualBusinessObject
    {
        private Data.Citas Data
        {
            get { return this.DataObject as Data.Citas; }
        }

        public Citas()
        {
            this.DataObject = new Data.Citas();
        }

        public List<Entities.Citas> ListarCitas(InglesIndividual.Entities.JQXGridSettings settings, DateTime fechaHora)
        {
            return this.Data.ListarCitas(settings, fechaHora);
        }

        public List<Exception> Eliminar(string[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (string id in ids)
                {
                    Entities.Citas item = new Entities.Citas(true);
                    item.IdCita = Utils.IsNull(id, 0);

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
