using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpCategoriaConfiguracionSel : StoredProcedure
    {
         public SpCategoriaConfiguracionSel()
            : base("SpCategoriaConfiguracionSel")
		{
			this.AddParameter("@pClaCategoria", System.Data.SqlDbType.Int, DBNull.Value);
		}

        public int ClaCategoria
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaCategoria"].Value, 0); }
            set { this.Command.Parameters["@pClaCategoria"].Value = value; }
        }
    }
}
