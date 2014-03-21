using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpPaisesUpd:  PagedStoredProcedure
    {
        
          
        public SpPaisesUpd(): base("SpPaisesUpd")
        {
                    
            this.AddParameter("@pClaPais", System.Data.SqlDbType.Int, 0);
            this.AddParameter("@pNomPais", System.Data.SqlDbType.VarChar, 50);

                   
        }
     
        public string NomPais
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNomPais"].Value, ""); }
            set { this.Command.Parameters["@pNomPais"].Value = value; }
        }

         public int ClaPais
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaPais"].Value,0); }
            set { this.Command.Parameters["@pClaPais"].Value = value; }
        }
    }
}

		
    
