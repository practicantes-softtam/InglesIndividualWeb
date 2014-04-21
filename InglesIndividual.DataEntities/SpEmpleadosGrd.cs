using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpEmpleadosGrd : PagedStoredProcedure
    {
         public SpEmpleadosGrd(): base("spEmpleadosGrd")
		{
			this.AddParameter("@pNombre", System.Data.SqlDbType.VarChar, "");
		}
		public string Nombre
		{
			get { return Utils.IsNull(this.Command.Parameters["@pNombre"].Value, ""); }
			set 
            {
                if (value == null)
                {
                    this.Command.Parameters["@pNombre"].Value = DBNull.Value;
                }
                else
                {
                    this.Command.Parameters["@pNombre"].Value = value;
                }
            }
		}
    }
}
