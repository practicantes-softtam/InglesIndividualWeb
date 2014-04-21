using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpHorarioMaestrosDel : StoredProcedure
    {
        public SpHorarioMaestrosDel() : base("SpHorarioMaestrosDel")
        {
            this.AddParameter("@pClaEmpleado", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaCampus", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaHorario", System.Data.SqlDbType.Int, DBNull.Value);
            this.Command.Parameters["@pClaEmpleado"].Direction = System.Data.ParameterDirection.Output;
            this.Command.Parameters["@pClaCampus"].Direction = System.Data.ParameterDirection.Output;
            this.Command.Parameters["@pClaHorario"].Direction = System.Data.ParameterDirection.Output;

        }

        public int ClaEmpleado
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaEmpleado"].Value, 0); }
            set { this.Command.Parameters["@pClaEmpleado"].Value = value; }
        }

        public int ClaCampus
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaCampus"].Value, 0); }
            set { this.Command.Parameters["@ClaCampus"].Value = value; }
        }

        public int ClaHorario
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaHorario"].Value, 0); }
            set { this.Command.Parameters["@ClaHorario"].Value = value; }
        }
    }
}



