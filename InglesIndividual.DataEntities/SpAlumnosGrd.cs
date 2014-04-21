using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpAlumnosGrd : PagedStoredProcedure
    {
        public SpAlumnosGrd(): base("spAlumnosGrd")
		{
			this.AddParameter("@pNombre", System.Data.SqlDbType.VarChar, "");
		}
		public string NomAlumno
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
