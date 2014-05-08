using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpAmpliacionesSel : StoredProcedure
    {
         public SpAmpliacionesSel()
            : base("SpAmpliacionesSel")
		{
			this.AddParameter("@pIdAmpliacion", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaNivel", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaLeccion", System.Data.SqlDbType.Int, DBNull.Value);
		}

        public int IdAmpliacion
        {
            get { return Utils.IsNull(this.Command.Parameters["@pIdAmpliacion"].Value, 0); }
            set { this.Command.Parameters["@pIdAmpliacion"].Value = value; }
        }

        public int ClaNivel
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaNivel"].Value, 0); }
            set { this.Command.Parameters["@pClaNivel"].Value = value; }
        }

        public int ClaLeccion
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaLeccion"].Value, 0); }
            set { this.Command.Parameters["@pClaLeccion"].Value = value; }
        }
    }
}
