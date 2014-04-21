using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
   public class SpEstadosGrd : PagedStoredProcedure
    {

       public SpEstadosGrd() : base("spEstadosGrd")
        {
            
            this.AddParameter("@pClaPais", System.Data.SqlDbType.Int, DBNull.Value);
	        this.AddParameter("@pNomEstado", System.Data.SqlDbType.VarChar, DBNull.Value);

        }

       public int ClaPais
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaPais"].Value, 0); }
            set { this.Command.Parameters["@pClaPais"].Value = value; }
        }

            public string NomEstado
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNomEstado"].Value, ""); }
            set { this.Command.Parameters["@pNomEstado"].Value = value; }
        }

    }
}
