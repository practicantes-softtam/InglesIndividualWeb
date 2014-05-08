using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpEmpleadosSel : StoredProcedure
    {
         public SpEmpleadosSel()
            : base("SpEmpleadosSel")
		{
			this.AddParameter("@pClaEmpleado", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaCampus", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaDepartamento", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaPuesto", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaPais", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaEstado", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaCiudad", System.Data.SqlDbType.Int, DBNull.Value);
		}

        public int ClaEmpleado
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaEmpleado"].Value, 0); }
            set { this.Command.Parameters["@pClaEmpleado"].Value = value; }
        }

        public int ClaCampus
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaCampus"].Value, 0); }
            set { this.Command.Parameters["@pClaCampus"].Value = value; }
        }

        public int ClaDepartamento
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaDepartamento"].Value, 0); }
            set { this.Command.Parameters["@pClaDepartamento"].Value = value; }
        }

        public int ClaPuesto
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaPuesto"].Value, 0); }
            set { this.Command.Parameters["@pClaPuesto"].Value = value; }
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
    }
}
