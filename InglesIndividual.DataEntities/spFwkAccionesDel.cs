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
            this.AddParameter("@pClaAccion", System.Data.SqlDbType.Char,"");
        }


        public string ClaAccion
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaAccion"].Value, ""); }
            set { this.Command.Parameters["@pClaPais"].Value = value; }
        }
    }
}
