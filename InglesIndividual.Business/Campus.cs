using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public List<Entities.Campus> ListarCampus(Entities.JQXGridSettings settings, string nombre, int pais, int ciudad, int estado)
        {
            return this.Data.ListarCampus(settings, nombre, pais, ciudad, estado);
        }
    }
}
