using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpHuellasPersonasGrd : PagedStoredProcedure
    {
        public SpHuellasPersonasGrd() : base("SpHuellasPersonasGrd")
        {
            this.AddParameter("@pIdRegistro", System.Data.SqlDbType.Int, DBNull.Value);
            this.Command.Parameters["@pIdRegistro"].Direction = System.Data.ParameterDirection.Output;
        }

        public int IdRegistro
        {
            get { return Utils.IsNull(this.Command.Parameters["@pIdRegistro"].Value, 0); }
            set
            {
                if (value == null)
                {
                    this.Command.Parameters["@pIdRegistrp"].Value = DBNull.Value;
                }
                else
                {
                    this.Command.Parameters["@pIdRegistro"].Value = value;
                }
            }
        }

    }
}
