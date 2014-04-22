using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
   public  class spFwkAccionesUpd :PagedStoredProcedure
    {
       public spFwkAccionesUpd(): base("spFwkAccionesUpd")
       {

           this.AddParameter("@pClaAccion", System.Data.SqlDbType.Char,"");
           this.AddParameter("@pDescripcion", System.Data.SqlDbType.VarChar, "");
       }

       public string ClaAccion
       {
           get { return Utils.IsNull(this.Command.Parameters["@pClaAccion"].Value, " "); }
           set { this.Command.Parameters["@pClaAccion"].Value = value; }
       }

       public string Descripcion
       {
           get { return Utils.IsNull(this.Command.Parameters["@pDescripcion"].Value, ""); }
           set { this.Command.Parameters["@pDescripcion"].Value = value; }
       }

    }
}
