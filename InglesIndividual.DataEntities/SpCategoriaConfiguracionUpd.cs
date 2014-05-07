using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpCategoriaConfiguracionUpd : StoredProcedure
    {
         public SpCategoriaConfiguracionUpd()
            : base("SpCategoriaConfiguracionUpd")
        {
            this.AddParameter("@pNomCategoria", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pClaCategoriaa", System.Data.SqlDbType.Int, DBNull.Value);
           // this.Command.Parameters["@pClaCategoria"].Direction = System.Data.ParameterDirection.Output;
    }
         public string NomCategoria
         {
             get { return Utils.IsNull(this.Command.Parameters["@pNomCategoria"].Value, ""); }
             set { this.Command.Parameters["@pNomCategoria"].Value = value; }
         }

         public int ClaCategoria
         {
             get { return Utils.IsNull(this.Command.Parameters["@pClaCategoria"].Value, 0); }
             set { this.Command.Parameters["@pClaCategoria"].Value = value; }
         }
    }
}
