using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpFwkUsuariosSistemaSeguridadGrd : PagedStoredProcedure
    {
        public SpFwkUsuariosSistemaSeguridadGrd() : base("SpFwkUsuariosSistemaSeguridadGrd")
            {
            this.AddParameter("@pIdRegistro", System.Data.SqlDbType.Int, DBNull.Value);
            this.Command.Parameters["@pIdRegistro"].Direction = System.Data.ParameterDirection.Output;
            this.AddParameter("@pIdUsuario", System.Data.SqlDbType.VarChar, DBNull.Value);                    
            }

        public int IdRegistro
        {
            get { return Utils.IsNull(this.Command.Parameters["@pIdRegistro"].Value, 0); }
            set { this.Command.Parameters["@pIdRegistro"].Value = value; }
        }
        
        public string IdUsuario
        {
            get { return Utils.IsNull(this.Command.Parameters["@pIdUsuario"].Value, ""); }
            set { this.Command.Parameters["@IdUsuario"].Value = value; }
        }
    }
}



