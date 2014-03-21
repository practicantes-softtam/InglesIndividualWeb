using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
	
namespace InglesIndividual.DataEntities
{
    public class SpFwkObjetosUpd : StoredProcedure
    {

        public SpFwkObjetosUpd(): base("spFwkObjetosUpd")
          {
            this.AddParameter("@pClaAplicacion", System.Data.SqlDbType.Int, 0);
            this.AddParameter("@pClaModulo", System.Data.SqlDbType.Int, 0);
            this.AddParameter("@pClaObjeto", System.Data.SqlDbType.Int, 0);
            this.AddParameter("@pClaveObjeto", System.Data.SqlDbType.VarChar, " ");
            this.AddParameter("@pNomObjeto", System.Data.SqlDbType.VarChar,  "");
            this.AddParameter("@pUrl", System.Data.SqlDbType.VarChar," ");
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

        public int ClaObjeto
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaObjeto"].Value, 0); }
            set { this.Command.Parameters["@pClaObjeto"].Value = value; }
        }

        public string ClaveObjeto
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaveObjeto"].Value, " "); }
            set { this.Command.Parameters["@ClaveObjeto"].Value = value; }

        }

                public string NomObjeto
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNomObjeto"].Value, " "); }
            set { this.Command.Parameters["@NomObjeto"].Value = value; }

        }
        public string Url
        {
            get { return Utils.IsNull(this.Command.Parameters["@pUrl"].Value, ""); }
            set { this.Command.Parameters["@pUrl"].Value = value; }
        }


    }
}