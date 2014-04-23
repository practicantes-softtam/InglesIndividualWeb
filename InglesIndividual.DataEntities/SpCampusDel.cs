﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpCampusDel : StoredProcedure
    {

        public SpCampusDel() : base("SpCampusDel")
        {
            this.AddParameter("@pNomCampus", System.Data.SqlDbType.VarChar, "");
        }

        public string NomCampus
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNomCampus"].Value, ""); }
            set { this.Command.Parameters["@pClaCampus"].Value = value; }
        }
    }
}