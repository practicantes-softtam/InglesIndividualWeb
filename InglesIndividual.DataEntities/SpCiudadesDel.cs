using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpCiudadesDel : StoredProcedure
    {
        public SpCiudadesDel()
            : base("SpCiudadesDel")
        {
            this.AddParameter("@pNomCiudad", System.Data.SqlDbType.VarChar, "");
        }
        public string NomCiudad
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNomCiudad"].Value, ""); }
            set { this.Command.Parameters["@pNomCiudad"].Value = value; }
        }
    }
}