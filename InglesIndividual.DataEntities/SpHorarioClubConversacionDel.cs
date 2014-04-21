using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpHorarioClubConversacionDel : StoredProcedure
    {
        public SpHorarioClubConversacionDel() : base("SpHorarioClubConversacionDel")
        {
            this.AddParameter("@pClaCampus", System.Data.SqlDbType.Int, 0);
            this.AddParameter("@pClaEmpleado", System.Data.SqlDbType.Int, 0);
            this.AddParameter("@pClaHorario", System.Data.SqlDbType.Int, 0);
            this.AddParameter("@pClaDia", System.Data.SqlDbType.Int, 0);
        }
        
        public int ClaCampus
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaCampus"].Value, 0); }
            set { this.Command.Parameters["@pClaCampus"].Value = value; }
        }

        public int ClaEmpleado
        {
            get { return Utils.IsNull(this.Command.Parameters["pClaEmpleado"].Value, 0); }
            set { this.Command.Parameters["@pClaEmpleado"].Value = value; }
        }

        public int ClaHorario
        {
            get { return Utils.IsNull(this.Command.Parameters["pClaHorario"].Value, 0); }
            set { this.Command.Parameters["@pClaHorario"].Value = value; }
        }

        public int ClaDia
        {
            get { return Utils.IsNull(this.Command.Parameters["pClaDia"].Value, 0); }
            set { this.Command.Parameters["@pClaDia"].Value = value; }
        }

    }
}