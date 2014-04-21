using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Business
{
    public class Empleados : InglesIndividualBusinessObject
    {
        private Data.Empleados Data
        {
            get { return this.DataObject as Data.Empleados; }
        }

        public Empleados()
        {
            this.DataObject = new Data.Empleados();
        }

        public List<Entities.Empleados> ListarEmpleados(InglesIndividual.Entities.JQXGridSettings settings, string nombre)
        {
            return this.Data.ListarEmpleados(settings, nombre);
        }

        public List<Exception> Eliminar(string[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (string id in ids)
                {
                    Entities.Empleados item = new Entities.Empleados(true);
                    item.ClaEmpleado = Utils.IsNull(id, 0);

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
