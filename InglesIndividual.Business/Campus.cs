using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Business
{
    public class Campus : InglesIndividualBusinessObject
    {
        private Data.FwkUsuarios Data
        {
            get { return this.DataObject as Data.FwkUsuarios; }
        }

        public Campus()
        {
            this.DataObject = new Data.FwkUsuarios();
        }

        public List<Entities.Campus> ListarCampus(Entities.JQXGridSettings settings, string nombre, int pais, int ciudad, int estado)
        {
            return this.Data.ListarCampus(settings, nombre, pais, ciudad, estado);
        }
    }
}
