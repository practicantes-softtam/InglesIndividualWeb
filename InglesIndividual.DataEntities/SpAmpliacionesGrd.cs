﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
	
namespace InglesIndividual.DataEntities
{
    public class SpAmpliacionesGrd : PagedStoredProcedure
    {
        public SpAmpliacionesGrd(): base("spAmpliacionesGrd")
		{
			this.AddParameter("@pMatricula", System.Data.SqlDbType.VarChar, "");
		}
		public string Matricula
		{
			get { return Utils.IsNull(this.Command.Parameters["@pMatricula"].Value, ""); }
			set 
            {
                if (value == null)
                {
                    this.Command.Parameters["@pMatricula"].Value = DBNull.Value;
                }
                else
                {
                    this.Command.Parameters["@pMatricula"].Value = value;
                }
            }
		}

    }
}
