using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpNivelesDel : StoredProcedure
   {
        public SpNivelesDel() : base("spNivelesDel")
        {
            this.AddParameter("@pClaNivel", System.Data.SqlDbType.Int, 0);
        }

        public int ClaNivel
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaNivel"].Value, 0); }
            set { this.Command.Parameters["@pClaNivel"].Value = value; }
        }
    }
}