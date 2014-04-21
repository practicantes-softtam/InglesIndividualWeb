using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpHuellasPersonasIns : StoredProcedure
    {
        public SpHuellasPersonasIns() : base("SpHuellasPersonasIns")
        {
            this.AddParameter("@pIdRegistro", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaCampus", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaEmpleado", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pMatricula", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pTipoPersona", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pHuella", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.Command.Parameters["@pIdRegistro"].Direction = System.Data.ParameterDirection.Output;
        }

        public int IdRegistro
        {
            get { return Utils.IsNull(this.Command.Parameters["@pIdRegistro"].Value, 0); }
            set { this.Command.Parameters["@pIdRegistro"].Value = value; }
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
        
        public string Matricula
        {
            get { return Utils.IsNull(this.Command.Parameters["@pMatricula"].Value, ""); }
            set { this.Command.Parameters["@pMatricula"].Value = value; }
        }
       
        public int TipoPersona
        {
            get { return Utils.IsNull(this.Command.Parameters["@pTipoPersona"].Value, 0); }
            set { this.Command.Parameters["@pTipoPersona"].Value = value; }
        }

        public string Huella
        {
            get { return Utils.IsNull(this.Command.Parameters["@pHuella"].Value, ""); }
            set { this.Command.Parameters["@pHuella"].Value = value; }
        }
    }
}



