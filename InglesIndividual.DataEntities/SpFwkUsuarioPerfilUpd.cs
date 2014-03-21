using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
   public class SpFwkUsuarioPerfilUpd:StoredProcedure
    {
       public SpFwkUsuarioPerfilUpd():base("spFwkUsuarioPerfilUpd")
       {
           this.AddParameter("@pIdUsuario", System.Data.SqlDbType.VarChar, " ");
           this.AddParameter("@pClaAplicacion", System.Data.SqlDbType.Int, 0);
           this.AddParameter("@ClaPerfil", System.Data.SqlDbType.Int, 0);

       }


       public string IdUsuario
       {
           get { return Utils.IsNull(this.Command.Parameters["@pIdUsuario"].Value, ""); }
           set { this.Command.Parameters["@pIdUsuario"].Value = value; }
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
           

    }
}
