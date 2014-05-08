using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpEncuestasSel : StoredProcedure
    {
         public SpEncuestasSel()
            : base("SpEncuestasSel")
		{
			this.AddParameter("@pClaEncuesta", System.Data.SqlDbType.Int, DBNull.Value);
		}

        public int ClaEncuesta
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaEncuesta"].Value, 0); }
            set { this.Command.Parameters["@pClaEncuesta"].Value = value; }
        }
    }
}
