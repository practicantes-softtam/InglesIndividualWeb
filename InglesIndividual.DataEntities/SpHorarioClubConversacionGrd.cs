using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpHorarioClubConversacionGrd : PagedStoredProcedure
    {
        public SpHorarioClubConversacionGrd() : base("spHorarioClubConversacionGrd")
        {
            this.AddParameter("@pClaCampus", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaEmpleado", System.Data.SqlDbType.Int, 0);
            this.AddParameter("@pClaHorario", System.Data.SqlDbType.Int, 0);
            this.AddParameter("@pClaDia", System.Data.SqlDbType.Int, 0);
            this.AddParameter("@pHoras", System.Data.SqlDbType.Int, 0);
            this.Command.Parameters["@pClaCampus"].Direction = System.Data.ParameterDirection.Output;
            this.Command.Parameters["@pClaEmpleado"].Direction = System.Data.ParameterDirection.Output;
            this.Command.Parameters["@pClaHorario"].Direction = System.Data.ParameterDirection.Output;
            this.Command.Parameters["@pClaDia"].Direction = System.Data.ParameterDirection.Output;
            
        }

        public int ClaCampus
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaCampus"].Value, 0); }
            set { this.Command.Parameters["@pClaCampus"].Value = value; }
        }

        public int ClaEmpleado
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaEmpleado"].Value, 0); }
            set { this.Command.Parameters["@pClaEmpleado"].Value = value; }
        }
        
        public int ClaHorario
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaHorario"].Value, 0); }
            set { this.Command.Parameters["@pClaHorario"].Value = value; }
        }
        
        public int ClaDia
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaDia"].Value, 0); }
            set { this.Command.Parameters["@pClaDia"].Value = value; }
        }
    }
}

