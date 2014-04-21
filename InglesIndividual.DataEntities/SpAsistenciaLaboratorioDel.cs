using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpAsistenciaLaboratorioDel : StoredProcedure
    {
        public SpAsistenciaLaboratorioDel(): base("spAsistenciaLaboratorioDel")
		{
			this.AddParameter("@pIdRegistroLaboratorio", System.Data.SqlDbType.Int, 0);
		}
        public int IdAsistenciaLaboratorio
		{
            get { return Utils.IsNull(this.Command.Parameters["@pIdAsistenciaLaboratorio"].Value, 0); }
            set { this.Command.Parameters["@pIdAsistenciaLaboratorio"].Value = value; }
		}
    }
}
