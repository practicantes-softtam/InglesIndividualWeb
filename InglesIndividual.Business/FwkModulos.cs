using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Business
{
    public class FwkModulos : InglesIndividualBusinessObject
    {
        private Data.FwkModulos Data
        {
            get { return this.DataObject as Data.FwkModulos; }
        }

        public FwkModulos()
        {
            this.DataObject = new Data.FwkModulos();
        }

        public List<Entities.FwkModulos> ListarFwkModulos(Entities.JQXGridSettings settings ,int claAplicacion,int claModulo,string nomModulo,int claModuloPadre)
        {
            return this.Data.ListarFwkModulos(settings, claAplicacion, claModulo, nomModulo,claModuloPadre);



        }
        public List<Exception> Eliminar(string[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (string id in ids)
                {
                    Entities.FwkModulos item = new Entities.FwkModulos(true);
                     
                     item.FwkAplicaciones.ClaAplicacion = Utils.IsNull(id, 0);
                     item.ClaModulo = Utils.IsNull(id, 0);


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
