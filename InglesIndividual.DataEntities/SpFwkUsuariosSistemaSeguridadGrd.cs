using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpFwkUsuariosSistemaSeguridadGrd : PagedStoredProcedure
    {
        public SpFwkUsuariosSistemaSeguridadGrd()
            : base("SpFwkUsuariosGrd")
        {
            this.AddParameter("@pIdRegistro", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pIdUsuario", System.Data.SqlDbType.Int, DBNull.Value);
            this.Command.Parameters["@pIdRegistro"].Direction = System.Data.ParameterDirection.Output;


        }

        public string NomCiudad
        {
            get { return Utils.IsNull(this.Command.Parameters["@pIdRegistro"].Value, ""); }
            set { this.Command.Parameters["@pIdRegistro"].Value = value; }
        }
        public int ClaEstado
        {
            get { return Utils.IsNull(this.Command.Parameters["@pIdUsuario"].Value, 0); }
            set { this.Command.Parameters["@IdUsuario"].Value = value; }
        }

    }
}



