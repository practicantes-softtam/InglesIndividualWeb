using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpPuestosIns : PagedStoredProcedure
    {
        public SpPuestosIns()
            : base("SpPuestosIns")
        {
            this.AddParameter("@pClaPuesto", System.Data.SqlDbType.Int, DBNull.Value);
            this.Command.Parameters["@pClaPuesto"].Direction = System.Data.ParameterDirection.Output;
            this.AddParameter("@pNomPuesto", System.Data.SqlDbType.VarChar, DBNull.Value);


        }

        public int ClaPuesto
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaPuesto"].Value, 0); }
            set { this.Command.Parameters["@pClaPuesto"].Value = value; }
        }



        public string NomPuesto
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNomPuesto"].Value, ""); }
            set { this.Command.Parameters["@pNomPuesto"].Value = value; }
        }


       }
}
