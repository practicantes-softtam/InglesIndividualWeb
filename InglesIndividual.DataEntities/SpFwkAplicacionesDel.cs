using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpFwkAplicacionesDel : StoredProcedure
    {
        public SpFwkAplicacionesDel()
            : base("spFwkAplicacionesDel")
        {
            this.AddParameter("@pClaAplicacion", System.Data.SqlDbType.Int, 0);


        }
        public int ClaAplicacion
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaAplicacion"].Value, 0); }
            set { this.Command.Parameters["@pClaAplicacion"].Value = value; }
        }


    }
}
