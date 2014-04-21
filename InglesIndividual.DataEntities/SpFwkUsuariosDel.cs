using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpFwkUsuariosDel : StoredProcedure
    {
        public SpFwkUsuariosDel()
            : base("SpFwkUsuariosDel")
        {
            this.AddParameter("@pIdUsuario", System.Data.SqlDbType.VarChar, "");
        }

        public string IdUsuario
        {
            get { return Utils.IsNull(this.Command.Parameters["@pIdUsuario"].Value, ""); }
            set { this.Command.Parameters["@pIdUsuario"].Value = value; }
        }
    }
}