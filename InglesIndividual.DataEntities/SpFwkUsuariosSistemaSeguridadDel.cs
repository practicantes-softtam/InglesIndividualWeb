using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpFwkUsuariosSistemaSeguridadDel : StoredProcedure
    {
        public SpFwkUsuariosSistemaSeguridadDel() : base("SpFwkUsuariosSistemaSeguridadDel")
        {
            this.AddParameter("@pIdRegistro", System.Data.SqlDbType.Int, 0);
            this.AddParameter("@pIdUsuario", System.Data.SqlDbType.VarChar, "");
        }

        public int IdRegistro
        {
            get { return Utils.IsNull(this.Command.Parameters["@pIdRegistro"].Value, 0); }
            set { this.Command.Parameters["@pIdRegistro"].Value = value; }
        }
        
        public string IdUsuario
        {
            get { return Utils.IsNull(this.Command.Parameters["@pIdUsuario"].Value, ""); }
            set { this.Command.Parameters["@pIdUsuario"].Value = value; }
        }

      }
}