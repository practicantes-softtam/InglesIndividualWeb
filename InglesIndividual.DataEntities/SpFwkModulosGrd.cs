using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
namespace InglesIndividual.DataEntities
{


    public class SpFwkModulosGrd : PagedStoredProcedure
    {


        public SpFwkModulosGrd()
            : base("spFwkModulosGrd")
        {
            this.AddParameter("@pClaAplicacion", System.Data.SqlDbType.Int, 0);
            this.AddParameter("@pClaModulo", System.Data.SqlDbType.Int, 0);
            this.AddParameter("@pNomModulo", System.Data.SqlDbType.VarChar, " ");
            this.AddParameter("@pClaModuloPadre", System.Data.SqlDbType.Int, 0);



        }
        public int ClaAplicaion
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaAplicaion"].Value, 0); }
            set { this.Command.Parameters["@pClaAplicacion"].Value = value; }
        }

        public int ClaModulo
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaModulo"].Value, 0); }
            set { this.Command.Parameters["@pClaModulo"].Value = value; }
        }




        public string NomModulo
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNomModulo"].Value, " "); }
            set { this.Command.Parameters["@pNomObjeto"].Value = value; }

        }
        public int ClaModuloPadre
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaModuloPadre"].Value, 0); }
            set { this.Command.Parameters["@pClaModuloPadre"].Value = value; }
        }


    }
}

