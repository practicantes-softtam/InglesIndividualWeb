using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpDepartamentosSel : StoredProcedure
    {
         public SpDepartamentosSel()
            : base("SpDepartamentosSel")
		{
			this.AddParameter("@pClaDepartamento", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaCampus", System.Data.SqlDbType.Int, DBNull.Value);
		}

        public int ClaDepartamento
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaDepartamento"].Value, 0); }
            set { this.Command.Parameters["@pClaDepartamento"].Value = value; }
        }

        public int ClaCampus
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaCampus"].Value, 0); }
            set { this.Command.Parameters["@pClaCampus"].Value = value; }
        }
    }
}
