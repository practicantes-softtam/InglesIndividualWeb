using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Business
{
    public class FwkUsuariosSistemaSeguridad : BaseBusinessObject
    {
        private Data.FwkUsuariosSistemaSeguridad Data
        {
            get { return this.DataObject as Data.FwkUsuariosSistemaSeguridad; }
        }

        public FwkUsuariosSistemaSeguridad()
        {
            this.DataObject = new Data.FwkUsuariosSistemaSeguridad();
        }

        public List<Entities.FwkUsuariosSistemaSeguridad> ListarFwkUsuariosSistemaSeguridad(InglesIndividual.Entities.JQXGridSettings settings, int IdRegistro)
        {
            return this.Data.ListarFwkUsuariosSistemaSeguridad(settings, IdRegistro);
        }

        public List<Exception> Eliminar(int[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (int id in ids)
                {
                    Entities.FwkUsuariosSistemaSeguridad item = new Entities.FwkUsuariosSistemaSeguridad(true);
                    item.IdRegistro = Utils.IsNull (id, 0);
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
