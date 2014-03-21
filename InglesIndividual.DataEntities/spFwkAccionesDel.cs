using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class spFwkAccionesDel :StoredProcedure
    {

        public spFwkAccionesDel()
            : base("spFwkAccionesDel")
        {
            this.AddParameter("@pClaAccion", System.Data.SqlDbType.Int, 0);
        }


        public int ClaAccion
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaAccion"].Value, 0); }
            set { this.Command.Parameters["@pClaPais"].Value = value; }
        }
    }
}
