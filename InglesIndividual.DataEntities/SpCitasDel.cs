using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpCitasDel : StoredProcedure
    {
        public SpCitasDel(): base("spCitasDel")
		{
			this.AddParameter("@pIdCita", System.Data.SqlDbType.Int, 0);
		}
		public int IdCita
		{
			get { return Utils.IsNull(this.Command.Parameters["@pIdCita"].Value, 0); }
			set { this.Command.Parameters["@pIdCita"].Value = value; }
		}
    }
}
