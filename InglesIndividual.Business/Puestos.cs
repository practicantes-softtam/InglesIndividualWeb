using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Framework;


namespace InglesIndividual.Business
{
    public class Puestos : InglesIndividualBusinessObject
    {
        private Data.Puestos Data
        {
            get { return this.DataObject as Data.Puestos; }
        }

        public Puestos()
        {
            this.DataObject = new Data.Puestos();
        }

        public List<Entities.Puesto> ListarPuestos(InglesIndividual.Entities.JQXGridSettings settings, string nomPuesto)
        {
            return this.Data.ListarPuestos(settings, nomPuesto);
        }

        public List<Exception> Eliminar(string[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (string id in ids)
                {
                    Entities.Puesto item = new Entities.Puesto(true);
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

        public List<Entities.Puesto> Combo()
        {
            return this.Data.Combo();
        }

    }
}
