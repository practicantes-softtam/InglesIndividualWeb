using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpSalonesDel : StoredProcedure
    {
        public int IdSalon;
        public SpSalonesDel()
            : base("SpSalonesDel")
        {
            this.AddParameter("@pIdSalones", System.Data.SqlDbType.Int, 0);
        }
        public int ClaNivel
        {
            get { return Utils.IsNull(this.Command.Parameters["@pIdSalones"].Value, 0); }
            set { this.Command.Parameters["@pIdSalones"].Value = value; }
        }
    }
}