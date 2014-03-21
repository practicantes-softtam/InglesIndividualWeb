using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpFwkUsuariosAplicacionGrd : PagedStoredProcedure
    {
        public SpFwkUsuariosAplicacionGrd()   : base("spFwkUsuariosAplicacionGrd")
        {
            this.AddParameter("@pClaAplicacion", System.Data.SqlDbType.Int, 0);
            this.AddParameter("@pIdUsuario", System.Data.SqlDbType.VarChar, " ");

        }
        public string IdUsuario
        {
            get { return Utils.IsNull(this.Command.Parameters["@pIdUsuario"].Value, ""); }
            set
            {
                if (value == null)
                {
                    this.Command.Parameters["@pIdUsuario"].Value = DBNull.Value;
                }
                else
                {
                    this.Command.Parameters["@pIdUsuario"].Value = value;
                }
            }
        }


        public int ClaAplicacion
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaAplicacion"].Value, 0); }
            set
            {
                if (value == null)
                {
                    this.Command.Parameters["@ClaAplicacion"].Value = DBNull.Value;
                }
                else
                {
                    this.Command.Parameters["ClaAplicacion"].Value = value;
                }
            }
        }

    }

}