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

        public List<Entities.Puestos> ListarPuestos(InglesIndividual.Entities.JQXGridSettings settings, int claPuesto)
        {
            return this.Data.ListarPuestos(settings, claPuesto);
        }

        public List<Exception> Eliminar(int[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (int id in ids)
                {
                    Entities.Puestos item = new Entities.Puestos(true);
                    item.ClaPuesto = Utils.IsNull(id, 0);

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



        public List<Entities.Puestos> ListarPuestos(Entities.JQXGridSettings settings, string nomPuesto)
        {
            throw new NotImplementedException();
        }
    }
}
