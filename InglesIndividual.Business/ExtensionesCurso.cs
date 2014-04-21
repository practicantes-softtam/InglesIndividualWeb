using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Business
{
    class ExtensionesCurso : InglesIndividualBusinessObject
    {
        private Data.ExtensionesCurso Data
        {
            get { return this.DataObject as Data.ExtensionesCurso; }
        }

        public ExtensionesCurso()
        {
            this.DataObject = new Data.ExtensionesCurso();
        }

        public List<Entities.ExtensionesCurso> ListarExtensionesCurso(InglesIndividual.Entities.JQXGridSettings settings, string matricula)
        {
            return this.Data.ListarExtensionesCurso(settings, matricula);
        }

        public List<Exception> Eliminar(string[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (string id in ids)
                {
                    Entities.ExtensionesCurso item = new Entities.ExtensionesCurso(true);
                    item.IdRegistro = Utils.IsNull(id, 0);

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
