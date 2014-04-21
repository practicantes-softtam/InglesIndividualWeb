using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpCiudadesGrd : PagedStoredProcedure
     {
    
        public SpCiudadesGrd(): base ("SpCiudadesGrd")
     {
            this.AddParameter("@pClaCiudad", System.Data.SqlDbType.Int, DBNull.Value);
	        this.AddParameter("@pClaEstado", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaPais", System.Data.SqlDbType.Int, DBNull.Value);
            this.Command.Parameters["@pClaCiudad"].Direction = System.Data.ParameterDirection.Output;
            this.Command.Parameters["@pClaEstado"].Direction = System.Data.ParameterDirection.Output;
            this.Command.Parameters["@pClaPais"].Direction = System.Data.ParameterDirection.Output;
            
     }

        public int ClaCiudad
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaCiudad"].Value, 0); }
            set { this.Command.Parameters["@pClaCiudad"].Value = value; }
        }

        public int ClaEstado
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaEstado"].Value, 0); }
            set { this.Command.Parameters["@pClaEstado"].Value = value; }
        }

        public int ClaPais
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaPais"].Value, 0); }
            set { this.Command.Parameters["@pClaPais"].Value = value; }
        }
    }
}
