using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
   public class spFwkAccionesIns :  StoredProcedure
    {
       	public spFwkAccionesIns(): base("spFwkAccionesIns")
		{
			this.AddParameter("@pClaAccion", System.Data.SqlDbType.Int, 0);
            this.AddParameter("@pDescripcion", System.Data.SqlDbType.VarChar,"");
            this.Command.Parameters["@pClaAccion"].Direction = System.Data.ParameterDirection.Output;
        }

        public int ClaAccion
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaAccion"].Value, 0); }
            set { this.Command.Parameters["@pClaAccion"].Value = value; }
        }

        public string Descripcion
        {
            get { return Utils.IsNull(this.Command.Parameters["@pDescripcion"].Value, ""); }
            set { this.Command.Parameters["@pDescripcion"].Value = value; }
        }

       
    }
}
