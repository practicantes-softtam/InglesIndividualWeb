using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpCategoriaConfiguracionGrd : PagedStoredProcedure
    {
         public SpCategoriaConfiguracionGrd(): base("spCategoriaConfiguracionGrd")
		{
			this.AddParameter("@pNomCategoria", System.Data.SqlDbType.VarChar, "");
		}
		public string NomCategoria
		{
			get { return Utils.IsNull(this.Command.Parameters["@pNomCategoria"].Value, ""); }
			set 
            {
                if (value == null)
                {
                    this.Command.Parameters["@pNomCategoria"].Value = DBNull.Value;
                }
                else
                {
                    this.Command.Parameters["@pNomCategoria"].Value = value;
                }
            }
		}

    }
}
