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
            : base("SpDepartamentosDel")
        {
            this.AddParameter("@pClaDepartamento", System.Data.SqlDbType.Int, 0);
        }
        public int ClaDepartamento
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaCampus"].Value, 0); }
            set { this.Command.Parameters["@pClaCampus"].Value = value; }
        }
    }
}