
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpDepartamentosGrd :PagedStoredProcedure
    {
         public SpDepartamentosGrd(): base("spDepartamentosGrd")
		{
			this.AddParameter("@pNomDepartamento", System.Data.SqlDbType.VarChar, "");
		}
		public string NomDepartamento
		{
			get { return Utils.IsNull(this.Command.Parameters["@pNomDepartamento"].Value, ""); }
			set 
            {
                if (value == null)
                {
                    this.Command.Parameters["@pNomDepartamento"].Value = DBNull.Value;
                }
                else
                {
                    this.Command.Parameters["@pNomDepartamento"].Value = value;
                }
            }
		}
    }
}