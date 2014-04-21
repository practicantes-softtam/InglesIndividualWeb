using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Business
{
    public class Departamentos : InglesIndividualBusinessObject
    {
        private Data.Departamentos Data
        {
            get { return this.DataObject as Data.Departamentos; }
        }

        public Departamentos()
        {
            this.DataObject = new Data.Departamentos();
        }

        public List<Entities.Departamentos> ListarDepartamentos(InglesIndividual.Entities.JQXGridSettings settings, string nomDepartamento)
        {
            return this.Data.ListarDepartamentos(settings, nomDepartamento);
        }

        public List<Exception> Eliminar(string[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (string id in ids)
                {
                    Entities.Departamentos item = new Entities.Departamentos(true);
                    item.ClaDepartamento = Utils.IsNull(id, 0);

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
