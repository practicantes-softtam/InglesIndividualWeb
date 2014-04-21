using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Business
{
    public class Ampliaciones : InglesIndividualBusinessObject
    {
        private Data.Ampliaciones Data
        {
            get { return this.DataObject as Data.Ampliaciones; }
        }

        public Ampliaciones()
        {
            this.DataObject = new Data.Ampliaciones();
        }

        public List<Entities.Ampliaciones> ListarAmpliaciones(InglesIndividual.Entities.JQXGridSettings settings, string matricula)
        {
            return this.Data.ListarAmpliaciones(settings, matricula);
        }

        public List<Exception> Eliminar(string[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (string id in ids)
                {
                    Entities.Ampliaciones item = new Entities.Ampliaciones(true);
                    item.idAmpliacion = Utils.IsNull(id, 0);

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
