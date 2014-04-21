using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpAsistenciaLaboratorioUpd : StoredProcedure
    {
        public SpAsistenciaLaboratorioUpd()
            : base("SpAsistenciaLaboratorioUpd")
        {
            this.AddParameter("@pClaCampus", System.Data.SqlDbType.Int, DBNull.Value);
        this.AddParameter("@pMatricula", System.Data.SqlDbType.VarChar, DBNull.Value);
        this.AddParameter("@pFecha", System.Data.SqlDbType.DateTime, DBNull.Value);
        this.AddParameter("@pIdRegistroLaboratorio", System.Data.SqlDbType.Int, DBNull.Value);
        this.Command.Parameters["@pIdRegistroLaboratorio"].Direction = System.Data.ParameterDirection.Output;
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

        public int Fecha
        {
            get { return Utils.IsNull(this.Command.Parameters["@pFecha"].Value, 0); }
            set { this.Command.Parameters["@pFecha"].Value = value; }
        }

        public int IdRegistroLaboratorio
        {
            get { return Utils.IsNull(this.Command.Parameters["@pIdRegistroLaboratorio"].Value, 0); }
            set { this.Command.Parameters["@pIdRegistroLaboratorio"].Value = value; }
        }
    }
}
