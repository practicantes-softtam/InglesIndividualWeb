using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Framework;

namespace InglesIndividual.Business
{
    public class Kardex : InglesIndividualBusinessObject
    {
        private Data.Kardex Data
        {
            get { return this.DataObject as Data.Kardex; }
        }

        public Kardex()
        {
            this.DataObject = new Data.Kardex();
        }

        public List<Entities.Kardex> ListarKardex(InglesIndividual.Entities.JQXGridSettings settings, string Matricula)
        {
            return this.Data.ListarKardex(settings, Matricula);
        }

        public List<Exception> Eliminar(int[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (int id in ids)
                {
                    Entities.Kardex item = new Entities.Kardex(true);
                    item.IdCalificacion = Utils.IsNull(id, 0);

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
