using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpSalonesGrd : PagedStoredProcedure
    {
         public SpSalonesGrd(): base("spSalonesGrd")
		{
			this.AddParameter("@pNomSalon", System.Data.SqlDbType.VarChar, "");
		}
		public string NomSalon
		{
			get { return Utils.IsNull(this.Command.Parameters["@pNomSalon"].Value, ""); }
			set 
            {
                if (value == null)
                {
                    this.Command.Parameters["@pNomSalon"].Value = DBNull.Value;
                }
                else
                {
                    this.Command.Parameters["@pNomSalon"].Value = value;
                }
            }
		}

    }
}
