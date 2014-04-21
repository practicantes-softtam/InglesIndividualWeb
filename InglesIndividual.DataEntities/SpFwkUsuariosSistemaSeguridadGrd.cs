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
                           
            }

        public int IdRegistro
        {
            get { return Utils.IsNull(this.Command.Parameters["@pIdRegistro"].Value, 0); }
            set 
            {
                if (value == null)
                {
                    this.Command.Parameters["@pIdRegistro"].Value = DBNull.Value;
                }
                else
                {
                    this.Command.Parameters["@pIdRegistro"].Value = value;
                }
            }
        }
    }
}
