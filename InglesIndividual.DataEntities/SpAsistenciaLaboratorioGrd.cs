using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpAsistenciaLaboratorioGrd : PagedStoredProcedure
    {
         public SpAsistenciaLaboratorioGrd(): base("spAsistenciaLaboratorioGrd")
		{
			this.AddParameter("@pFecha", System.Data.SqlDbType.DateTime, DateTime.Now);
		}
		public DateTime Fecha
		{
			get { return Utils.IsNull(this.Command.Parameters["@pFechaHora"].Value, DateTime.Now); }
			set 
            {
                if (value == null)
                {
                    this.Command.Parameters["@pFecha"].Value = DBNull.Value;
                }
                else
                {
                    this.Command.Parameters["@pFecha"].Value = value;
                }
            }
		}
    }
}
