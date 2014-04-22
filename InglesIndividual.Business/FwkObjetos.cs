using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Business
{
    public class FwkObjetos : InglesIndividualBusinessObject
    {
        private Data.FwkObjetos Data
        {
            get { return this.DataObject as Data.FwkObjetos; }
        }

        public  FwkObjetos()
        {
            this.DataObject = new Data.FwkObjetos();
        }

        public List<Entities.FwkObjetos> ListarFwkObjetos(Entities.JQXGridSettings settings, int claAplicacion, int claModulo,int claObjeto, string claveObjeto, string nomObjeto, string url)
        {
            return this.Data.ListarFwkObjetos(settings, claAplicacion, claModulo,claObjeto, claveObjeto, nomObjeto, url);



        }
        public List<Exception> Eliminar(string[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (string id in ids)
                {
                    Entities.FwkObjetos item = new Entities.FwkObjetos(true);
                    item.ClaAplicacion.ClaAplicacion = Utils.IsNull(id, 0);
                    item.ClaModulo.ClaModulo = Utils.IsNull(id, 0);


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
