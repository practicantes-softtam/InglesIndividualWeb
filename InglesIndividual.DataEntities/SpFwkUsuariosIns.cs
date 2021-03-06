﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpFwkUsuariosIns : PagedStoredProcedure
    {
        public SpFwkUsuariosIns()
            : base("SpFwkUsuariosIns")
        {
            this.AddParameter("@pIdUsuario", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pNomUsuario", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pPassword", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pEmail", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.Command.Parameters["@pIdUsuario"].Direction = System.Data.ParameterDirection.Output;
        }

        public string IdUsuario
        {
            get { return Utils.IsNull(this.Command.Parameters["@pIdUsuario"].Value, ""); }
            set { this.Command.Parameters["@pIdUsuario"].Value = value; }
        }
        
        public string NomUsuario
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNomUsuario"].Value, ""); }
            set { this.Command.Parameters["@pNomUsuario"].Value = value; }
        }
        
        public string Password
        {
            get { return Utils.IsNull(this.Command.Parameters["@pPassword"].Value, ""); }
            set { this.Command.Parameters["@pPassword"].Value = value; }
        }
        
        public string Email
        {
            get { return Utils.IsNull(this.Command.Parameters["@pEmail"].Value, ""); }
            set { this.Command.Parameters["@pEmail"].Value = value; }
        }
    }
}



