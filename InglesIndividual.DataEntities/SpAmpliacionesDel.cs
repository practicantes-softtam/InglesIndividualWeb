using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpAmpliacionesDel : StoredProcedure
    {
        public SpAmpliacionesDel(): base("spAmpliacionesDel")
		{
			this.AddParameter("@pIdAmpliacion", System.Data.SqlDbType.Int, 0);
		}
		public int IdAmpliacion
		{
			get { return Utils.IsNull(this.Command.Parameters["@pIdAmpliacion"].Value, 0); }
			set { this.Command.Parameters["@pIdAmpliacion"].Value = value; }
		}

    }
}
