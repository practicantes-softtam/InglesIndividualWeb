using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpAsistenciaLaboratorioSel : StoredProcedure
    {
         public SpAsistenciaLaboratorioSel()
            : base("SpAsistenciaLaboratorioSel")
		{
			this.AddParameter("@pIdAsistenciaLaboaratorio", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaCampus", System.Data.SqlDbType.Int, DBNull.Value);
		}

         public int IdAsistenciaLaboratorio
        {
            get { return Utils.IsNull(this.Command.Parameters["@pIdAsistenciaLaboratorio"].Value, 0); }
            set { this.Command.Parameters["@pIdAsistenciaLaboratorio"].Value = value; }
        }

         public int ClaCampus
         {
             get { return Utils.IsNull(this.Command.Parameters["@pClaCampus"].Value, 0); }
             set { this.Command.Parameters["@pClaCampus"].Value = value; }
         }
    }
}
