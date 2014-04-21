using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpEmpleadosDel : StoredProcedure
    {
         public SpEmpleadosDel(): base("spEmpleadossDel")
		{
			this.AddParameter("@pClaEmpleado", System.Data.SqlDbType.Int, 0);
		}
		public int ClaEmpleado
		{
			get { return Utils.IsNull(this.Command.Parameters["@pClaEmpleado"].Value, 0); }
			set { this.Command.Parameters["@pClaEmpleado"].Value = value; }
		}
    }
}
