using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Business
{
    public class FwkPermisosAdicionales : InglesIndividualBusinessObject
    {
        private Data.FwkPermisosAdicionales Data
        {
            get { return this.DataObject as Data.FwkPermisosAdicionales; }
        }



        public List<Entities.FwkPermisosAdicionales> ListarFwkPermisosAdicionales(Entities.JQXGridSettings settings, string idUsuario, int claAplicacion, int claModulo, int claObjeto, string claAccion, int permitir)

        
        {
            return this.Data.ListarFwkPermisosAdicionales (settings, idUsuario,claAplicacion,claModulo,claObjeto,claAccion,permitir);

        
        }
        public List<Exception> Eliminar(string[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (string id in ids)
                {
                    Entities.FwkPermisosAdicionales item = new Entities.FwkPermisosAdicionales(true);
                    item.IdUsuario.IdUsuario = Utils.IsNull(id, "");
                    item.ClaAplicacion.ClaAplicacion = Utils.IsNull(id, 0);
                    item.ClaModulo.ClaModulo = Utils.IsNull(id, 0);
                    item.ClaObjeto.ClaObjeto = Utils.IsNull(id, 0);
                    item.ClaAccion.ClaAccion = Utils.IsNull(id, "" );

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
