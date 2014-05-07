using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpEstadosSel : StoredProcedure
    {
        public SpEstadosSel()
            : base("SpEstadosSel")
        {
            this.AddParameter("@pClaPais", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaEstado", System.Data.SqlDbType.Int, DBNull.Value);
        }

        public int ClaPais
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaPais"].Value, 0); }
            set { this.Command.Parameters["@pClaPais"].Value = value; }
        }

        public int ClaEstado
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaEstado"].Value, 0); }
            set { this.Command.Parameters["@pClaEstado"].Value = value; }
        }

    }
}

