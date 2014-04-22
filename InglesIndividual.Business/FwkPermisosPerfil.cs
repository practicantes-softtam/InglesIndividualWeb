using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Business
{
    public class FwkPermisosPerfil : InglesIndividualBusinessObject
    {
        private Data.FwkPermisosPerfil Data
        {
            get { return this.DataObject as Data.FwkPermisosPerfil; }
        }



        public List<Entities.FwkPermisosPerfil> ListarFwkPermisosPerfil(Entities.JQXGridSettings settings,  int claAplicacion,int claPerfil, int claModulo, int claObjeto, string claAccion, int permitir)
        {
            return this.Data.ListarFwkPerimisosPerfil(settings, claAplicacion,claPerfil, claModulo, claObjeto, claAccion, permitir);


        }
        public List<Exception> Eliminar(string[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (string id in ids)
                {
                    Entities.FwkPermisosPerfil item = new Entities.FwkPermisosPerfil(true);
                    item.ClaAplicacion.ClaAplicacion = Utils.IsNull(id, 0);
                    item.ClaPerfil.ClaPerfil = Utils.IsNull(id, 0);
                    item.ClaModulo.ClaModulo = Utils.IsNull(id, 0);
                    item.ClaObjeto.ClaObjeto = Utils.IsNull(id, 0);
                    item.ClaAccion.ClaAccion = Utils.IsNull(id, "");

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
