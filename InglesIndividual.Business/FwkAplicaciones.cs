using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;


namespace InglesIndividual.Business
{
    public class FwkAplicaciones : BaseBusinessObject
    {
        private Data.FwkAplicaciones Data
        {
            get { return this.DataObject as Data.FwkAplicaciones; }
        }

        public FwkAplicaciones()
        {
            this.DataObject = new Data.FwkAplicaciones();
        }

        public List<Entities.FwkAplicaciones> ListarFwkaplicacion(InglesIndividual.Entities.JQXGridSettings settings, int claAplicacion, string nomFwkAplicaciones)
        {
            return this.Data.ListarFwkAplicaciones(settings,claAplicacion, nomFwkAplicaciones);
        }

        public List<Exception> Eliminar(string[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (string id in ids)
                {
                    Entities.FwkAplicaciones item = new Entities.FwkAplicaciones(true);
                    item.ClaAplicacion = Utils.IsNull(id, 0);

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
