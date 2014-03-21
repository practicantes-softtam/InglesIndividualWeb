using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpFwkPerfilesDel: StoredProcedure
    {
        public SpFwkPerfilesDel(): base("spFwkPerfilesDel")
        {

            this.AddParameter("@pClaAplicacion", System.Data.SqlDbType.Int, 0);
            this.AddParameter("@pClaPerfil", System.Data.SqlDbType.Int, 0);
           

        }

        public int ClaAplicaion
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaAplicaion"].Value, 0); }
            set { this.Command.Parameters["@pClaAplicacion"].Value = value; }
        }

        public int ClaPerfil
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaPerfil"].Value, 0); }
            set { this.Command.Parameters["@pClaPerfil"].Value = value; }
        }
    }
}
