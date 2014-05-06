using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Framework;

namespace InglesIndividual.Business
{
    public class HuellasPersonas : InglesIndividualBusinessObject
    {
        private Data.HuellasPersonas Data
        {
            get { return this.DataObject as Data.HuellasPersonas; }
        }

        public HuellasPersonas()
        {
            this.DataObject = new Data.HuellasPersonas();            
        }

        public List<Entities.HuellasPersonas> ListarHuellasPersonas(InglesIndividual.Entities.JQXGridSettings settings, int idRegistro, string Matricula, int ClaEmpleado)
        {
            return this.Data.ListarHuellasPersonas(settings, idRegistro, Matricula, ClaEmpleado);
        }

        public List<Exception> Eliminar(int[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (int id in ids)
                {
                    Entities.HuellasPersonas item = new Entities.HuellasPersonas(true);
                    item.ID = Utils.IsNull(id, 0);

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

