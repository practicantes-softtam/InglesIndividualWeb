using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Business
{
    public class Asistencia : InglesIndividualBusinessObject
    {
        private Data.Asistencia Data
        {
            get { return this.DataObject as Data.Asistencia; }
        }

        public Asistencia()
        {
            this.DataObject = new Data.Asistencia();
        }

        public List<Entities.Asistencia> ListarAsistencia(InglesIndividual.Entities.JQXGridSettings settings, DateTime fechaHora)
        {
            return this.Data.ListarAsistencia(settings, fechaHora);
        }

        public List<Exception> Eliminar(string[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (string id in ids)
                {
                    Entities.Asistencia item = new Entities.Asistencia(true);
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
