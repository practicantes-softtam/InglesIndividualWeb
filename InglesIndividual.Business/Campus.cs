using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Business
{
    public class Campus : InglesIndividualBusinessObject
    {
        private Data.Campus Data
        {
            get { return this.DataObject as Data.Campus; }
        }

        public Campus()
        {
            this.DataObject = new Data.Campus();
        }

        public List<Entities.Campus> ListarCampus(InglesIndividual.Entities.JQXGridSettings settings, string nomCampus, string calle, string colonia, string telefono, int claPais, int claEstado, int claCiudad)
        {
            return this.Data.ListarCampus(settings, nomCampus, calle, colonia, telefono,claPais,claEstado,claCiudad );
        }

        public List<Exception> Eliminar(string[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (string id in ids)
                {
                    Entities.Campus item = new Entities.Campus(true);
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

        public List<Entities.Campus> Combo()
        {
            return this.Data.Combo();
        }


        public List<Entities.Campus> ListarCampus(Entities.JQXGridSettings settings, string nomCampus, string calle, string colonia, string telefono)
        {
            throw new NotImplementedException();
        }
    }
}
