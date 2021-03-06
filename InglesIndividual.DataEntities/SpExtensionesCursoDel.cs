﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpExtensionesCursoDel : StoredProcedure
    {
        public SpExtensionesCursoDel(): base("spExtensionesCursoDel")
		{
			this.AddParameter("@pIdRegistro", System.Data.SqlDbType.Int, 0);
		}
		public int IdRegistro
		{
			get { return Utils.IsNull(this.Command.Parameters["@pIdRegistro"].Value, 0); }
			set { this.Command.Parameters["@pIdRegistro"].Value = value; }
		}
    }
}
