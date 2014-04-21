using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
	public class SpFwkAccionesGrd : PagedStoredProcedure
	{
		public SpFwkAccionesGrd(): base("spFwkAccionesGrd")
		{
			this.AddParameter("@pDescripcion", System.Data.SqlDbType.VarChar, "");
		}
		public string Descripcion
		{
            get { return Utils.IsNull(this.Command.Parameters["@pDescripcion"].Value, ""); }
			set 
            {
                if (value == null)
                {
                    this.Command.Parameters["@pDescripcion"].Value = DBNull.Value;
                }
                else
                {
                    this.Command.Parameters["@pDescripcion"].Value = value;
                }
            }
		}
	}
}