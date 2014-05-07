using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
   public class SpEstadosIns : StoredProcedure
    {
       public SpEstadosIns()
            : base("SpEstadosIns")
        {
            this.AddParameter("@pClaPais", System.Data.SqlDbType.Int, DBNull.Value);
	        this.AddParameter("@pNomEstado", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pClaEstado", System.Data.SqlDbType.Int, DBNull.Value);
           // this.Command.Parameters["@pClaEstado"].Direction = System.Data.ParameterDirection.Output;


        }
      
       public int ClaPais
       {
           get { return Utils.IsNull(this.Command.Parameters["@pClaPais"].Value, 0); }
           set { this.Command.Parameters["@pClaPais"].Value = value; }
       }

        public string NomEstado
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNomEstado"].Value, ""); }
            set { this.Command.Parameters["@pNomEstado"].Value = value; }
        }

        public int ClaEstado
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaEstado"].Value, 0); }
            set { this.Command.Parameters["@pClaEstado"].Value = value; }
        }


    }
}
