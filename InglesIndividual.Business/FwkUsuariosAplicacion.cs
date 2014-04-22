using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Business
{
    public class FwkUsuariosAplicacion : InglesIndividualBusinessObject
    {
        private Data.FwkUsuarioAplicacion Data
        {
            get { return this.DataObject as Data.FwkUsuarioAplicacion; }
        }



        public List<Entities.FwkUsuarioAplicacion> ListarFwkUsuarioAplicacion(Entities.JQXGridSettings settings, int claAplicacion, string idUsuario)
        {
            return this.Data.ListarFwkUsuarioAplicacion(settings, claAplicacion,idUsuario);


        }
        public List<Exception> Eliminar(string[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (string id in ids)
                {
                    Entities.FwkUsuarioAplicacion item = new Entities.FwkUsuarioAplicacion(true);
                    item.FwkAplicacion.ClaAplicacion = Utils.IsNull(id, 0);
                    item.FwkUsuario.IdUsuario = Utils.IsNull(id, "");

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
