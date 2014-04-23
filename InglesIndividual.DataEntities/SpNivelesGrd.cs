﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpNivelesGrd : PagedStoredProcedure
    {

        public SpNivelesGrd()
            : base("spNivelesGrd")
        {
            this.AddParameter("@pClaNivel", System.Data.SqlDbType.Int, 0);
            this.AddParameter("@pNomNivel", System.Data.SqlDbType.VarChar, "");
        }

        public int ClaNivel
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaNivel"].Value, 0); }
            set { this.Command.Parameters["@pClaNivel"].Value = value; }
        }

        public string NomNivel
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNomNivel"].Value, ""); }
            set { this.Command.Parameters["@pNomNivel"].Value = value; }
        }
    }
}