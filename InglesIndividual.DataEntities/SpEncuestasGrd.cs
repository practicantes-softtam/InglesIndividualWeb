using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpEncuestasGrd : PagedStoredProcedure
    {
         public SpEncuestasGrd(): base("spEncuestasGrd")
		{
			this.AddParameter("@pNomEncuesta", System.Data.SqlDbType.VarChar, "");
		}
		public string NomEncuesta
		{
			get { return Utils.IsNull(this.Command.Parameters["@pNomEncuesta"].Value, ""); }
			set 
            {
                if (value == null)
                {
                    this.Command.Parameters["@pNomEncuesta"].Value = DBNull.Value;
                }
                else
                {
                    this.Command.Parameters["@pNomEncuesta"].Value = value;
                }
            }
		}
    }
}
