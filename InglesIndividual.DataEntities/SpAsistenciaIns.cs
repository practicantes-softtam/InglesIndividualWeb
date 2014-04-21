using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpAsistenciaIns : StoredProcedure
    {
        public SpAsistenciaIns()
            : base("SpAsistenciaIns")
        {
            this.AddParameter("@pClaCampus", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pMatricula", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pClaEmpleado", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pTipoPersona", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pFechaHora", System.Data.SqlDbType.DateTime, DBNull.Value);
            this.AddParameter("@pMensaje", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pIdCita", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pRegistroValido", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pIdRegistro", System.Data.SqlDbType.Int, DBNull.Value);
            this.Command.Parameters["@pIdRegistro"].Direction = System.Data.ParameterDirection.Output;
    }

        public int ClaCampus
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaCampus"].Value, 0); }
            set { this.Command.Parameters["@pClaCampus"].Value = value; }
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

        public int TipoPersona
        {
            get { return Utils.IsNull(this.Command.Parameters["@pTipoPersona"].Value, 0); }
            set { this.Command.Parameters["@pTipoPersona"].Value = value; }
        }

        public DateTime FechaHora
        {
            get { return Utils.IsNull(this.Command.Parameters["@pFechaHora"].Value, DateTime.Now); }
            set { this.Command.Parameters["@pFechaHora"].Value = value; }
        }

        public string Mensaje
        {
            get { return Utils.IsNull(this.Command.Parameters["@pMensaje"].Value, ""); }
            set { this.Command.Parameters["@pMensaje"].Value = value; }
        }

        public int IdCita
        {
            get { return Utils.IsNull(this.Command.Parameters["@pIdCita"].Value, 0); }
            set { this.Command.Parameters["@pIdCita"].Value = value; }
        }

        public int RegistroValido
        {
            get { return Utils.IsNull(this.Command.Parameters["@pRegistroValido"].Value, 0); }
            set { this.Command.Parameters["@pRegistroValido"].Value = value; }
        }

        public int IdRegistro
        {
            get { return Utils.IsNull(this.Command.Parameters["@pIdRegistro"].Value, 0); }
            set { this.Command.Parameters["@pIdRegistro"].Value = value; }
        }
    }
}