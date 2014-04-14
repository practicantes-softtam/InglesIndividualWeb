using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Business
{
    public class FwkUsuarioPErfil: InglesIndividualBusinessObject
    {
        private Data.FwkUsusarioPerfil Data
        {
            get { return this.DataObject as Data.FwkUsusarioPerfil; }
        }



        public List<Entities.FwkUsuarioPerfil> ListarFwkUsuarioPerfil(Entities.JQXGridSettings settings, string idUsuario,int claAplicacion, int claPerfil)

        {
            return this.Data.ListarFwkUsuarioPerfil(settings, idUsuario,claAplicacion,claPerfil );


        }
        public List<Exception> Eliminar(string[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (string id in ids)
                {
                    Entities.FwkUsuarioPerfil item = new Entities.FwkUsuarioPerfil(true);
                    item.IdUsuario.IdUsuario = Utils.IsNull(id, "");
                    item.ClaAplicacion.ClaAplicacion = Utils.IsNull(id, 0);
                    item.ClaPerfil.ClaPerfil = Utils.IsNull(id, 0);

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

