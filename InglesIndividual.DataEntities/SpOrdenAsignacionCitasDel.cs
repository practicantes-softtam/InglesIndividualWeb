using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpOrdenAsignacionCitasDel : StoredProcedure
    {
        public SpOrdenAsignacionCitasDel()
            : base("SpOrdenAsignacionCitasDel")
        {
            this.AddParameter("@pClaCampus", System.Data.SqlDbType.Int, 0);
        }
        public int ClaNivel
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaCampus"].Value, 0); }
            set { this.Command.Parameters["@pClaCampus"].Value = value; }
        }
    }
}