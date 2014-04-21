using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpConfiguracionIns : StoredProcedure
    {
        public SpConfiguracionIns()
            : base("SpConfiguracionIns")
        {
            this.AddParameter("@pNomConfiguracion", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pValorEntero", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pValorCadena", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pEditale", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaCategoria", System.Data.SqlDbType.Int, DBNull.Value);
            this.Command.Parameters["@pClaCategoria"].Direction = System.Data.ParameterDirection.Output;
            this.AddParameter("@pClaConfig", System.Data.SqlDbType.Int, DBNull.Value);
            this.Command.Parameters["@pClaConfig"].Direction = System.Data.ParameterDirection.Output;

        }
        public string NomConfiguracion
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNomConfiguracion"].Value, ""); }
            set { this.Command.Parameters["@pNomConfiguracion"].Value = value; }
        }

        public int ValorEntero
        {
            get { return Utils.IsNull(this.Command.Parameters["@pValorEntero"].Value, 0); }
            set { this.Command.Parameters["@pValorEntero"].Value = value; }
        }

        public string ValorCadena
        {
            get { return Utils.IsNull(this.Command.Parameters["@pValorCadena"].Value, ""); }
            set { this.Command.Parameters["@pValorCadena"].Value = value; }
        }

        public int Editable
        {
            get { return Utils.IsNull(this.Command.Parameters["@pEditable"].Value, 0); }
            set { this.Command.Parameters["@pEditable"].Value = value; }
        }

        public int ClaCategoria
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaCategoria"].Value, 0); }
            set { this.Command.Parameters["@pClaCategoria"].Value = value; }
        }

        public int ClaConfig
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaConfig"].Value, 0); }
            set { this.Command.Parameters["@pClaConfig"].Value = value; }
        }
    }
}
