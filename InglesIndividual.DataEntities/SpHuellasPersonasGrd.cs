using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpHuellasPersonasGrd : PagedStoredProcedure
    {
        public SpHuellasPersonasGrd()
            : base("SpHuellasPersonasGrd")
        {
            this.AddParameter("@pIdRegistro", System.Data.SqlDbType.Int, 0);
            this.AddParameter("@pMatricula", System.Data.SqlDbType.VarChar, "");
            this.AddParameter("@pClaEmpleado", System.Data.SqlDbType.Int, 0);
        }

        public int IdRegistro
        {
            get { return Utils.IsNull(this.Command.Parameters["@pIdRegistro"].Value, 0); }
            set { this.Command.Parameters["@pIdRegistro"].Value = value; }
        }
        public string Matricula
        {
            get { return Utils.IsNull(this.Command.Parameters["@pMatricula"].Value, ""); }
            set { this.Command.Parameters["@pMatricula"].Value = value; }
        }

        public int ClaEmpleado
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaEmpleado"].Value, 0); }
            set { this.Command.Parameters["@pClaEmpleado"].Value = value; }
        }
    }
}