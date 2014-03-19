using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpCampusGrd : PagedStoredProcedure
    {
        public SpCampusGrd() : base("SpCampusGrd")
        {
            this.AddParameter("@pNomCampus", System.Data.SqlDbType.VarChar, DBNull.Value);
	        this.AddParameter("@pClaPais", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaEstado", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaCiudad", System.Data.SqlDbType.Int, DBNull.Value);
        }

        public string NomCampus
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNomCampus"].Value, ""); }
            set { this.Command.Parameters["@pNomCampus"].Value = value; }
        }

        public int ClaPais
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaPais"].Value, 0); }
            set { this.Command.Parameters["@pClaPais"].Value = value; }
        }

        public int ClaEstado
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaEstado"].Value, 0); }
            set { this.Command.Parameters["@pClaEstado"].Value = value; }
        }

        public int ClaCiudad
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaCiudad"].Value, 0); }
            set { this.Command.Parameters["@pClaCiudad"].Value = value; }
        }
    }
}
