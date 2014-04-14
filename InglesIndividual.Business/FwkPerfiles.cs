using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Business
{
    public class FwkPerfiles : InglesIndividualBusinessObject
    {
        private Data.FwkPerfil Data
        {
            get { return this.DataObject as Data.FwkPerfil; }
        }

        

        public List<Entities.FwkObjetos> ListarFwkPerfiles(Entities.JQXGridSettings settings, int claAplicacion, int claPerfil, string nomPerfil)
        {
            return this.Data.ListarFwkPerfiles(settings, claAplicacion,claPerfil, nomPerfil);



        }
        public List<Exception> Eliminar(string[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (string id in ids)
                {
                    Entities.FwkPerfiles item = new Entities.FwkPerfiles(true);
                    item.ClaAplicacion.ClaAplicacion = Utils.IsNull(id, 0);
                    item.ClaPerfil = Utils.IsNull(id, 0);


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
