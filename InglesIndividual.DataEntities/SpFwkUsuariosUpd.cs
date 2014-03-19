using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpFwkUsuariosUpd : PagedStoredProcedure
    {
        public SpFwkUsuariosUpd()
            : base("SpFwkUsuariosUpd")
        {
            this.AddParameter("@pIdUsuario", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pNomUsuario", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pPassword", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pEmail", System.Data.SqlDbType.VarChar, DBNull.Value);
            
        }

        public string NomCiudad
        {
            get { return Utils.IsNull(this.Command.Parameters["@@pIdUsuario"].Value, ""); }
            set { this.Command.Parameters["@pIdUsuario"].Value = value; }
        }
        public int ClaEstado
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNomUsuario"].Value, 0); }
            set { this.Command.Parameters["@pNomUsuario"].Value = value; }
        }
        public int ClaPais
        {
            get { return Utils.IsNull(this.Command.Parameters["@pPassword"].Value, 0); }
            set { this.Command.Parameters["@pPassword"].Value = value; }
        }
        public int ClaCiudad
        {
            get { return Utils.IsNull(this.Command.Parameters["@pEmail"].Value, 0); }
            set { this.Command.Parameters["@pEmail"].Value = value; }
        }



    }
}
