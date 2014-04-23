using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpDepartamentosDel : StoredProcedure
    {

        public SpDepartamentosDel()
            : base("spDepartamentosDel")
        {
            this.AddParameter("@pNomDepartamento", System.Data.SqlDbType.VarChar, "");
        }
        public string NomDepartamento
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNomDepartamento"].Value, ""); }
            set { this.Command.Parameters["@pClaDepartamento"].Value = value; }
        }

    }
}