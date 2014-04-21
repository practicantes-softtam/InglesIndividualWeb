using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Business
{
    public class Alumnos : InglesIndividualBusinessObject
    {
        private Data.Alumnos Data
        {
            get { return this.DataObject as Data.Alumnos; }
        }

        public Alumnos()
        {
            this.DataObject = new Data.Alumnos();
        }

        public List<Entities.Alumnos> ListarAlumnos(InglesIndividual.Entities.JQXGridSettings settings, string nombre)
        {
            return this.Data.ListarAlumnos(settings, nombre);
        }

        public List<Exception> Eliminar(string[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (string id in ids)
                {
                    Entities.Alumnos item = new Entities.Alumnos(true);
                    item.Matricula = Utils.IsNull(id, "");

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
