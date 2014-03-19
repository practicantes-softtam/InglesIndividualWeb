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
            this.AddParameter("@pClaCiudad", System.Data.SqlDbType.Int, 0);
        }
        public int ClaCiudad
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaCiudad"].Value, 0); }
            set { this.Command.Parameters["@pClaCiudad"].Value = value; }
        }
    }
}