
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpDepartamentosUpd : StoredProcedure
    {
        public SpDepartamentosUpd()
            : base("SpDepartamentosUpd")
        {
            this.AddParameter("@pClaCampus", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pNomDepartamento", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pClaDepartamento", System.Data.SqlDbType.Int, DBNull.Value);
           // this.Command.Parameters["@pClaDepartamento"].Direction = System.Data.ParameterDirection.Output;
   }
        public int ClaCampus
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaCampus"].Value, 0); }
            set { this.Command.Parameters["@pClaCampus"].Value = value; }
        }

        public string NomDepartamentos
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNomDepartamentos"].Value, ""); }
            set { this.Command.Parameters["@pNomDepartamentos"].Value = value; }
        }

        public int ClaDepartamento
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaDepartamento"].Value, 0); }
            set { this.Command.Parameters["@pClaDepartamento"].Value = value; }
        }
    }
}