using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Business
{
    public class CategoriaConfiguracion : InglesIndividualBusinessObject
    {
        private Data.CategoriaConfiguracion Data
        {
            get { return this.DataObject as Data.CategoriaConfiguracion; }
        }

        public CategoriaConfiguracion()
        {
            this.DataObject = new Data.CategoriaConfiguracion();
        }

        public List<Entities.CategoriaConfiguracion> ListarCategoriaConfiguracion(InglesIndividual.Entities.JQXGridSettings settings, string nomCategoria)
        {
            return this.Data.ListarCategoriaConfiguracion(settings, nomCategoria);
        }

        public List<Exception> Eliminar(string[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (string id in ids)
                {
                    Entities.CategoriaConfiguracion item = new Entities.CategoriaConfiguracion(true);
                    item.ClaCategoria = Utils.IsNull(id, 0);

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
