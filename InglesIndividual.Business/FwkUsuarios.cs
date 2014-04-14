using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Business
{
    public class FwkUsuarios : BaseBusinessObject
    {
        private Data.FwkUsuarios Data
        {
            get { return this.DataObject as Data.FwkUsuarios; }
        }

        public FwkUsuarios()
        {
            this.DataObject = new Data.FwkUsuarios();
        }

        public List<Entities.FwkUsuarios> ListarFwkUsuarios(InglesIndividual.Entities.JQXGridSettings settings, string nomUsuario)
        {
            return this.Data.ListarFwkUsuarios(settings, nomUsuario);
        }

        public List<Exception> Eliminar(string[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (string id in ids)
                {
                    Entities.FwkUsuarios item = new Entities.FwkUsuarios(true);
                    item.IdUsuario = Utils.IsNull(id, "");

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
