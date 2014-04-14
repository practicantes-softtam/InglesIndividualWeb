using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpSalonesIns : PagedStoredProcedure
    {
        public SpSalonesIns()
            : base("SpSalonesIns")
        {
            this.AddParameter("@pIdSalon", System.Data.SqlDbType.Int, DBNull.Value);
            this.Command.Parameters["@pIdSalon"].Direction = System.Data.ParameterDirection.Output;
            this.AddParameter("@pClaCampus", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pNomSalon", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pCapacidad", System.Data.SqlDbType.Int, DBNull.Value);
            
        }

        public int IdSalon
        {
            get { return Utils.IsNull(this.Command.Parameters["@pIdSalon"].Value, 0); }
            set { this.Command.Parameters["@pIdSalon"].Value = value; }
        }

        public string ClaCampus
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaCampus"].Value, ""); }
            set { this.Command.Parameters["@pClaCampus"].Value = value; }
        }

        public string NomSalon
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNomSalon"].Value, ""); }
            set { this.Command.Parameters["@pNomSalon"].Value = value; }
        }

        
        public int Capacidad
        {
            get { return Utils.IsNull(this.Command.Parameters["@pCapacidad"].Value, 0); }
            set { this.Command.Parameters["@pCapacidad"].Value = value; }
        }

     }
}
