using System;
using Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace InglesIndividual.DataEntities
{
	public class SpFwkAccionesGrd : PagedStoredProcedure
	{
		public SpFwkAccionesGrd(): base("spFwkAccionesGrd")
		{
            this.AddParameter("@pClaAccion", System.Data.SqlDbType.Char, " ");
            this.AddParameter("@pDescripcion", System.Data.SqlDbType.VarChar, "");
            this.Command.Parameters["@pClaAccion"].Direction = System.Data.ParameterDirection.Output;
        }

        public string ClaAccion
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaAccion"].Value, " "); }
            set { this.Command.Parameters["@pClaAccion"].Value = value; }
        }

        public string Descripcion
        {
            get { return Utils.IsNull(this.Command.Parameters["@pDescripcion"].Value, ""); }
            set { this.Command.Parameters["@pDescripcion"].Value = value; }
        }


    }
}