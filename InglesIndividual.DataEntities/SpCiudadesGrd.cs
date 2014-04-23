using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpCiudadesGrd : PagedStoredProcedure
     {
    
        public SpCiudadesGrd(): base ("SpCiudadesGrd")
     {
            this.AddParameter("@pNomCiudad", System.Data.SqlDbType.VarChar, DBNull.Value);
            
     }

        public string NomCiudad
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNomCiudad"].Value, ""); }
            set { this.Command.Parameters["@pNomCiudad"].Value = value; }
        }
    }
}
