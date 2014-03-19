using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpKardexDel : StoredProcedure
    {
        public SpKardexDel()
            : base("SpKardexDel")
        {
            this.AddParameter("@pIdCalificacion", System.Data.SqlDbType.Int, 0);
        }
        public int ClaNivel
        {
            get { return Utils.IsNull(this.Command.Parameters["@pIdCalificacion"].Value, 0); }
            set { this.Command.Parameters["@pIdCalificacion"].Value = value; }
        }
    }
}