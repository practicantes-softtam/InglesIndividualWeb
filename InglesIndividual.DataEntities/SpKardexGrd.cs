using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpKardexGrd : PagedStoredProcedure
    {
        public SpKardexGrd() : base("SpKardexGrd")
        {
            this.AddParameter("@pIdCalificacion", System.Data.SqlDbType.Int, DBNull.Value);
            this.Command.Parameters["@pIdCalificacion"].Direction = System.Data.ParameterDirection.Output;
         
        }

        public int IdCalificacion
        {
            get { return Utils.IsNull(this.Command.Parameters["@pIdCalificacion"].Value, 0); }
            set 
            {
                if (value == null)
                {
                    this.Command.Parameters["@pIdCalificacion"].Value = DBNull.Value;
                }
                else
                {
                    this.Command.Parameters["@pIdCalificacion"].Value = value;
                }
            }
		}

    }
}
