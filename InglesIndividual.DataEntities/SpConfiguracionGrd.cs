using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpConfiguracionGrd : PagedStoredProcedure
    {
        public SpConfiguracionGrd() : base("spConfiguracionGrd")
		{
			this.AddParameter("@pNomConfig", System.Data.SqlDbType.VarChar, "");
		}
		public string NomConfiguracion
		{
			get { return Utils.IsNull(this.Command.Parameters["@pNomconfig"].Value, ""); }
			set 
            {
                if (value == null)
                {
                    this.Command.Parameters["@pNomConfig"].Value = DBNull.Value;
                }
                else
                {
                    this.Command.Parameters["@pNomConfig"].Value = value;
                }
            }
		}

    }
}
