using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
	public class SpPuestosDel : StoredProcedure
	{
		public SpPuestosDel(): base("spPuestosDel")
		{
			this.AddParameter("@pClaPuesto", System.Data.SqlDbType.Int, 0);
		}
		public int ClaPuesto
		{
			get { return Utils.IsNull(this.Command.Parameters["@pClaPuesto"].Value, 0); }
			set { this.Command.Parameters["@pClaPuesto"].Value = value; }
		}

	}
}