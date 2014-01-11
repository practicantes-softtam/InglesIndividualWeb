using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
	public class SpPuestosGrd : PagedStoredProcedure
	{
		public SpPuestosGrd(): base("spPuestosGrd")
		{
			this.AddParameter("@pNomPuesto", System.Data.SqlDbType.VarChar, "");
		}
		public string NomPuesto
		{
			get { return Utils.IsNull(this.Command.Parameters["@pNomPuesto"].Value, ""); }
			set 
            {
                if (value == null)
                {
                    this.Command.Parameters["@pNomPuesto"].Value = DBNull.Value;
                }
                else
                {
                    this.Command.Parameters["@pNomPuesto"].Value = value;
                }
            }
		}
	}
}