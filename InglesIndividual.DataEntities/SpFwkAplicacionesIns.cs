using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;


namespace InglesIndividual.DataEntities
{
    public class SpFwkAplicacionesIns : StoredProcedure
	{
   
		public SpFwkAplicacionesIns(): base("spAplicacionesIns")
		{
			this.AddParameter("@pClaAplicacion", System.Data.SqlDbType.Int, 0);
            this.AddParameter("@pNomAplicacion", System.Data.SqlDbType.VarChar," ");
            
           
     

		}
		public int ClaAplicaion
		{
			get { return Utils.IsNull(this.Command.Parameters["@pClaAplicaion"].Value, 0); }
			set { this.Command.Parameters["@pClaAplicacion"].Value = value; }
		}

        public string NomAplicacion
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNomAplicacion"].Value, ""); }
            set { this.Command.Parameters["@pNomAplicacion"].Value=value; }
        }


	}
}


