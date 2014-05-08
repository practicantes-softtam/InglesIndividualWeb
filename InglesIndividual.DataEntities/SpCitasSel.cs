using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpCitasSel : StoredProcedure
    {
         public SpCitasSel()
            : base("SpCitasSel")
		{
			this.AddParameter("@pIdCita", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaCampus", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaProfesor", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaNivel", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaLEccion", System.Data.SqlDbType.Int, DBNull.Value);
		}

        public int IdCita
        {
            get { return Utils.IsNull(this.Command.Parameters["@pIdCita"].Value, 0); }
            set { this.Command.Parameters["@pIdCIta"].Value = value; }
        }

        public int ClaCampus
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaCampus"].Value, 0); }
            set { this.Command.Parameters["@pClaCampus"].Value = value; }
        }

        public int ClaProfesor
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaProfesor"].Value, 0); }
            set { this.Command.Parameters["@pClaProfesor"].Value = value; }
        }

        public int CLaNivel
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaNivel"].Value, 0); }
            set { this.Command.Parameters["@pCLaNivel"].Value = value; }
        }

        public int ClaLeccion
        {
            get { return Utils.IsNull(this.Command.Parameters["@pCLaLeccion"].Value, 0); }
            set { this.Command.Parameters["@pCLaLeccion"].Value = value; }
        }
    }
}
