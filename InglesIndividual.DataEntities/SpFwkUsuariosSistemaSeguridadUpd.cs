﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpFwkUsuariosUpd : PagedStoredProcedure
    {
        public SpFwkUsuariosUpd()
            : base("SpFwkUsuariosUpd")
        {
            this.AddParameter("@pIdRegistro", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pIdUsuario", System.Data.SqlDbType.VarCha, DBNull.Value);
            
        }

        public int IdRegistro
        {
            get { return Utils.IsNull(this.Command.Parameters["@pIdRegistro"].Value, 0); }
            set { this.Command.Parameters["@pIdUsuario"].Value = value; }
        }
        public string ClaEstado
        {
            get { return Utils.IsNull(this.Command.Parameters["@pIdUsuario"].Value, ""); }
            set { this.Command.Parameters["@pIdUsuario"].Value = value; }
        }
        
    }
}
