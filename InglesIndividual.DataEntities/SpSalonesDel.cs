using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpSalonesDel : StoredProcedure
    {
        public SpSalonesDel(): base("spSalonesDel")
		{
			this.AddParameter("@pIdSalon", System.Data.SqlDbType.Int, 0);
		}
		public int IdSalon
		{
			get { return Utils.IsNull(this.Command.Parameters["@pIdSalon"].Value, 0); }
			set { this.Command.Parameters["@pIdSalon"].Value = value; }
		}
    }
}
