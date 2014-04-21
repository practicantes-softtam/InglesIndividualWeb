using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpPuestoIns : StoredProcedure
    {
        public SpPuestoIns()
            : base("SpPuestoIns")
        {
            this.AddParameter("@pNombre", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pClaPuesto", System.Data.SqlDbType.Int, DBNull.Value);
            this.Command.Parameters["@pClaPuesto"].Direction = System.Data.ParameterDirection.Output;
        }
    }
}
