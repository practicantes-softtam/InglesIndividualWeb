using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;


namespace InglesIndividual.DataEntities
{    
		public class SpPaisesIns : StoredProcedure
	{
		public SpPaisesIns(): base("spPaisesIns")
		{
			this.AddParameter("@pClaPais", System.Data.SqlDbType.Int, 0);
            this.AddParameter("@pNomPais", System.Data.SqlDbType.VarChar," ");
            this.Command.Parameters["@pClaPais"].Direction = System.Data.ParameterDirection.Output;
           

		}
		public int ClaPais
		{
			get { return Utils.IsNull(this.Command.Parameters["@pClaPais"].Value, 0); }
			set { this.Command.Parameters["@pClaPais"].Value = value; }
		}

        public string NomPais
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNomPais"].Value, ""); }
            set { this.Command.Parameters["@pNomPais"].Value=value; }
        }


	}
}