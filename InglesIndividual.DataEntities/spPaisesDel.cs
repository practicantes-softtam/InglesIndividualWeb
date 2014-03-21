using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
  public  class spPaisesDel: StoredProcedure
	{
		public spPaisesDel(): base("spPaisesDel")
		{
			this.AddParameter("@pClaPais", System.Data.SqlDbType.Int, 0);
            

		}
		public int ClaPais
		{
			get { return Utils.IsNull(this.Command.Parameters["@pClaPais"].Value, 0); }
			set { this.Command.Parameters["@pClaPais"].Value = value; }
		}

       
	}
}
