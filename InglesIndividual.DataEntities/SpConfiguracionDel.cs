﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpConfiguracionDel : StoredProcedure
    {
         public SpConfiguracionDel(): base("spConfiguracionDel")
		{
			this.AddParameter("@pClaCategoria", System.Data.SqlDbType.Int, 0);
            this.AddParameter("@pClaConfig", System.Data.SqlDbType.Int, 0);
		}
		public int ClaCategoria
		{
			get { return Utils.IsNull(this.Command.Parameters["@pClaCategoria"].Value, 0); }
			set { this.Command.Parameters["@pClaCategoria"].Value = value; }
		}

        public int ClaConfig
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaConfig"].Value, 0); }
            set { this.Command.Parameters["@pClaConfig"].Value = value; }
        }
    }
}
