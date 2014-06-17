using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpNivelesSel : StoredProcedure
    {
        public SpNivelesSel()
            : base("SpNivelesSel")
        {
            this.AddParameter("@pClaNivel", System.Data.SqlDbType.Int, DBNull.Value);
        }

        public int ClaNivel
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaNivel"].Value, 0); }
            set { this.Command.Parameters["@pClaNivel"].Value = value; }
        }
    }
}