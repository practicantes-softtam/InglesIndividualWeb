using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Business
{
    public class AsistenciaLaboratorio : InglesIndividualBusinessObject
    {

        private Data.AsistenciaLaboratorio Data
        {
            get { return this.DataObject as Data.AsistenciaLaboratorio; }
        }

        public AsistenciaLaboratorio()
        {
            this.DataObject = new Data.AsistenciaLaboratorio();
        }

        public List<Entities.AsistenciaLaboratorio> ListarAsistenciaLaboratorio(InglesIndividual.Entities.JQXGridSettings settings, DateTime fechaHora)
        {
            return this.Data.ListarAsistenciaLaboratorio(settings, fechaHora);
        }

        public List<Exception> Eliminar(string[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (string id in ids)
                {
                    Entities.AsistenciaLaboratorio item = new Entities.AsistenciaLaboratorio(true);
                    item.IdAsistenciaLaboratorio = Utils.IsNull(id, 0);

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
