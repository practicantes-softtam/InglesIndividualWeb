using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpPuestoUpd : StoredProcedure
    {
          public SpPuestoUpd()
            : base("SpPuestoUpd")
        {
            this.AddParameter("@pNombre", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pClaPuesto", System.Data.SqlDbType.Int, DBNull.Value);
            this.Command.Parameters["@pClaPuesto"].Direction = System.Data.ParameterDirection.Output;
        }

          public string Nombre
          {
              get { return Utils.IsNull(this.Command.Parameters["@pNombre"].Value, ""); }
              set { this.Command.Parameters["@pNombre"].Value = value; }
          }

          public int ClaPuesto
          {
              get { return Utils.IsNull(this.Command.Parameters["@pClaPuesto"].Value, 0); }
              set { this.Command.Parameters["@pClaPuesto"].Value = value; }
          }
    }
}
