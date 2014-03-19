using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpLeccionesDel : StoredProcedure
    {
        public SpLeccionesDel()
            : base("SpLeccionesDel")
        {
            this.AddParameter("@pClaLeccion", System.Data.SqlDbType.Int, 0);
        }
        public int ClaLeccion
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaLeccion"].Value, 0); }
            set { this.Command.Parameters["@pClaLeccion"].Value = value; }
        }
    }
}