using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;


namespace InglesIndividual.Business
{
    public class FwkAcciones: BaseBusinessObject    
    {
         private Data.FwkAcciones Data
        {
            get { return this.DataObject as Data.FwkAcciones; }
        }

        public FwkAcciones()
        {
            this.DataObject = new Data.FwkAcciones();
        }

        public List<Entities.FwkAcciones> ListarFwkAcciones(InglesIndividual.Entities.JQXGridSettings settings,string claAccion, string descripcion)
        {
            return this.Data.ListarFwkAcciones(settings, claAccion,descripcion);
        }

        public List<Exception> Eliminar(string[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (string id in ids)
                {
                    Entities.FwkAcciones item = new Entities.FwkAcciones(true);
                    item.ClaAccion = Utils.IsNull(id, "");

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
