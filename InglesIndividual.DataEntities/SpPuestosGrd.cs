using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
	public class SpPuestosGrd : PagedStoredProcedure
	{
		public SpPuestosGrd(): base("SpPuestosGrd")
		{
			this.AddParameter("@pClaPuesto", System.Data.SqlDbType.Int, DBNull.Value);
		}
        public int ClaCiudad
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaPuesto"].Value, 0); }
            set { this.Command.Parameters["@pClaPuesto"].Value = value; }
        }
	}
}