using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpLeccionesDel : StoredProcedure
    {
        public SpLeccionesDel() : base("SpLeccionesDel")
        {
            this.AddParameter("@pClaLeccion", System.Data.SqlDbType.Int, 0);
            this.AddParameter("@pClaNivel", System.Data.SqlDbType.Int, 0);
            this.AddParameter("@pNomLeccion", System.Data.SqlDbType.VarChar, "");
        }

        public int ClaLeccion
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaLeccion"].Value, 0); }
            set { this.Command.Parameters["@pClaLeccion"].Value = value; }
        }

        public int ClaNivel
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaNivel"].Value, 0); }
            set { this.Command.Parameters["@pClaNivel"].Value = value; }
        }
        
        public string NomLeccion
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNomLeccion"].Value, ""); }
            set { this.Command.Parameters["@pNomLeccion"].Value = value; }
        }
    }
}