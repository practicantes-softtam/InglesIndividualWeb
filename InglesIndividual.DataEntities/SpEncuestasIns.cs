using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpEncuestasIns : StoredProcedure
    {
        public SpEncuestasIns() : base("spEncuestasIns")
        {
            this.AddParameter("@pClaEncuesta", System.Data.SqlDbType.Int, 0);
            this.AddParameter("@pNomEncuesta", System.Data.SqlDbType.VarChar, "");
        }

        public int ClaEncuesta
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaEncuesta"].Value, 0); }
            set { this.Command.Parameters["@pClaEncuesta"].Value = value; }

        }   

        public string NomEncuesta
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNomEncuesta"].Value, ""); }
            set { this.Command.Parameters["@pNomEncuesta"].Value = value; }
        }
    }
}
