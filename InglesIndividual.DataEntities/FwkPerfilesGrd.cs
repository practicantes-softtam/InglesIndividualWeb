using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
namespace InglesIndividual.DataEntities
{
    

   public class SpPerfilesGrd:  PagedStoredProcedure
    {
        
          
        public SpPerfilesGrd(): base("SpPaisesGrd")
        {
                    
            this.AddParameter("@pNomPerfil", System.Data.SqlDbType.VarChar, " ");
                   
        }
     
        public String NomPerfil
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNomPerfil"].Value, ""); }
            set { this.Command.Parameters["@pNomPerfil"].Value = value; }
        }

    }
}

