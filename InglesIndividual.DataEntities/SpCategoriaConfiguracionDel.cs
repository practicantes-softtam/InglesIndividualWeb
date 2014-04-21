using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpCategoriaConfiguracionDel : StoredProcedure
    {
         public SpCategoriaConfiguracionDel(): base("spCategoriaConfiguracionDel")
		{
			this.AddParameter("@pClaCategoria", System.Data.SqlDbType.Int, 0);
		}
		public int ClaCategoria
		{
			get { return Utils.IsNull(this.Command.Parameters["@pClaCategoria"].Value, 0); }
			set { this.Command.Parameters["@pClaCategoriaConfiguracion"].Value = value; }
		}
    }
}
