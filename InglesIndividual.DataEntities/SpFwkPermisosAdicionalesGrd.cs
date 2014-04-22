using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
namespace InglesIndividual.DataEntities
{


    public class SpFwkPermisosAdicionalesGrd : PagedStoredProcedure
    {


       public SpFwkPermisosAdicionalesGrd()
           : base("spFwkPermisosAdicionalesGrd")
       { 
           this.AddParameter("@pIdUsuario", System.Data.SqlDbType.VarChar, " ");
           this.AddParameter("@pClaAplicacion", System.Data.SqlDbType.Int, 0);
           this.AddParameter("@pClaModulo", System.Data.SqlDbType.Int, 0);
           this.AddParameter("@pClaObjeto",System.Data.SqlDbType.Int,0);
           this.AddParameter("@pClaAccion",System.Data.SqlDbType.Char,"");
           this.AddParameter("@pPermitir",System.Data.SqlDbType.TinyInt,0);
                          
       }

       public string IdUsuario
       {
           get { return Utils.IsNull(this.Command.Parameters["@pIdUsuario"].Value,""); }
           set { this.Command.Parameters["@pIdUsuario"].Value = value; }
       }

       public int ClaAplicaion
       {
           get { return Utils.IsNull(this.Command.Parameters["@pClaAplicaion"].Value, 0); }
           set { this.Command.Parameters["@pClaAplicacion"].Value = value; }
       }

       public int ClaModulo
       {
           get { return Utils.IsNull(this.Command.Parameters["@pClaModulo"].Value, 0); }
           set { this.Command.Parameters["@pClaModulo"].Value = value; }
       }

       public int ClaObjeto
       {
           get { return Utils.IsNull(this.Command.Parameters["@pClaObjeto"].Value, 0); }
           set { this.Command.Parameters["@pClaObjeto"].Value = value; }
       }

       public string ClaAccion
       {
           get { return Utils.IsNull(this.Command.Parameters["@pClaAccion"].Value, ""); }
           set { this.Command.Parameters["@pClaAccion"].Value = value; }
       }

       public int Permitir
       {
           get { return Utils.IsNull(this.Command.Parameters["@pPermitir"].Value, 0); }
           set { this.Command.Parameters["@pPermitir"].Value = value; }
       }


    }
}