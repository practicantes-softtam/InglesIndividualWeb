using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpAlumnosDel : StoredProcedure
    {

        public SpAlumnosDel(): base("spAlumnosDel")
		{
			this.AddParameter("@pMatricula", System.Data.SqlDbType.VarChar, "");
		}
		public string Matricula
		{
			get { return Utils.IsNull(this.Command.Parameters["@pMatricula"].Value, ""); }
			set { this.Command.Parameters["@pMatricula"].Value = value; }
		}
    }
}
