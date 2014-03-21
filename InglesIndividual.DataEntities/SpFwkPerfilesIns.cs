using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
     public class SpFwkPerfilesIns : StoredProcedure
    {
         public SpFwkPerfilesIns(): base("spFwkPerfilesIns")
         {

             this.AddParameter("@pClaAplicacion", System.Data.SqlDbType.Int, 0);
             this.AddParameter("@pClaPerfil", System.Data.SqlDbType.Int, 0);
             this.AddParameter("@pNomPerfil", System.Data.SqlDbType.VarChar, "");
             
            }

         public int ClaAplicaion
         {
             get { return Utils.IsNull(this.Command.Parameters["@pClaAplicaion"].Value, 0); }
             set { this.Command.Parameters["@pClaAplicacion"].Value = value; }
         }

         public int ClaPerfil
         {
             get { return Utils.IsNull(this.Command.Parameters["@pClaPerfil"].Value, 0); }
             set { this.Command.Parameters["@pClaPerfil"].Value = value; }
         }

         public string NomPerfil
         {
             get { return Utils.IsNull(this.Command.Parameters["@pNomPerfil"].Value," "); }
             set { this.Command.Parameters["@pNomPerfil"].Value = value; }
         }



    }
}
