using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities 
{
  public class SpEstadosDel : StoredProcedure
    {

        public SpEstadosDel()
            : base("SpEstadosDel")
        {
            this.AddParameter("@pClaEstado", System.Data.SqlDbType.Int, 0);
        }
        public int ClaEstado
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaEstado"].Value, 0); }
            set { this.Command.Parameters["@pClaEstado"].Value = value; }
        }
    }
}
