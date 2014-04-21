using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Business
{
    public class Configuracion : InglesIndividualBusinessObject
    {
        private Data.Configuracion Data
        {
            get { return this.DataObject as Data.Configuracion; }
        }

        public Configuracion()
        {
            this.DataObject = new Data.Configuracion();
        }

        public List<Entities.Configuracion> ListarConfiguracion(InglesIndividual.Entities.JQXGridSettings settings, string nomConfiguracion)
        {
            return this.Data.ListarConfiguracion(settings, nomConfiguracion);
        }

        public List<Exception> Eliminar(string[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (string id in ids)
                {
                    Entities.Configuracion item = new Entities.Configuracion(true);
                    item.ClaCategoria = Utils.IsNull(id, 0);
                    item.ClaConfig = Utils.IsNull(id, 0);
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
