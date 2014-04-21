using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
   public class SpAsistenciaGrd : PagedStoredProcedure
    {
         public SpAsistenciaGrd(): base("spAsistenciaGrd")
		{
			this.AddParameter("@pFechaHora", System.Data.SqlDbType.DateTime, DateTime.Now);
		}
		public DateTime FechaHora
		{
			get { return Utils.IsNull(this.Command.Parameters["@pFechaHora"].Value, DateTime.Now); }
			set 
            {
                if (value == null)
                {
                    this.Command.Parameters["@pFechaHora"].Value = DBNull.Value;
                }
                else
                {
                    this.Command.Parameters["@pFechaHora"].Value = value;
                }
            }
		}

    }
}
