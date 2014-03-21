using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
namespace InglesIndividual.DataEntities
{
    

   public class SpPaisesGrd:  PagedStoredProcedure
    {
        
          
        public SpPaisesGrd(): base("SpPaisesGrd")
        {
                    
            this.AddParameter("@pNomPais", System.Data.SqlDbType.VarChar, 50);
                   
        }
     
        public string NomPais
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNomPais"].Value, ""); }
            set { this.Command.Parameters["@pNomPais"].Value = value; }
        }

    }
}
