using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Business
{
   public class Estados : InglesIndividualBusinessObject
    {

       private Data.Estados Data
       {
           get { return this.DataObject as Data.Estados; }
       }

        public Estados()
        {
            this.DataObject = new Data.Estados();
        }

        public List<Entities.Estado> ListarEstados(InglesIndividual.Entities.JQXGridSettings settings, int claPais, string nomEstado)
        {
      
            return this.Data.ListarEstados(settings, claPais, nomEstado);
            
        }

        public List<Exception> Eliminar(string[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (string id in ids)
                {
                    Entities.Estado item = new Entities.Estado(true);
                    item.Clave = Utils.IsNull(id, 0);

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
