using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpAlumnosSel : StoredProcedure
    {
         public SpAlumnosSel()
            : base("SpAlumnosSel")
		{
            this.AddParameter("@pMatricula", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pClaPais", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaEstado", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaCiudad", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaCampus", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaNivel", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaLeccion", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaAtendio", System.Data.SqlDbType.Int, DBNull.Value);
		}

         public string Matricula
         {
             get { return Utils.IsNull(this.Command.Parameters["@pMatricula"].Value, ""); }
             set { this.Command.Parameters["@pMatricula"].Value = value; }
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

        public int ClaCiudad
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaCiudad"].Value, 0); }
            set { this.Command.Parameters["@pClaCiudad"].Value = value; }
        }

        public int ClaCampus
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaCampus"].Value, 0); }
            set { this.Command.Parameters["@pClaCampus"].Value = value; }
        }

        public int ClaNivel
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaNivel"].Value, 0); }
            set { this.Command.Parameters["@pClaNivel"].Value = value; }
        }

        public int ClaLeccion
        {
            get { return Utils.IsNull(this.Command.Parameters["@pCClaLeccion"].Value, 0); }
            set { this.Command.Parameters["@pClaLeccion"].Value = value; }
        }

        public int ClaAtendio
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaAtendio"].Value, 0); }
            set { this.Command.Parameters["@pClaAtendio"].Value = value; }
        }
    }
}
