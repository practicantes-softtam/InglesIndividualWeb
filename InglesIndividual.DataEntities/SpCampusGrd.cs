using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpCampusGrd : PagedStoredProcedure
    {
        public SpCampusGrd() : base("SpCampusGrd")
        {

            this.AddParameter("@pNomCampus", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pCalle", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pColonia", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pTelefono", System.Data.SqlDbType.VarChar, DBNull.Value);

        }

        public string NomCampus
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNomCampus"].Value, ""); }
            set { this.Command.Parameters["@pNomCampus"].Value = value; }
        }

        public string Calle
        {
            get { return Utils.IsNull(this.Command.Parameters["@pCalle"].Value, ""); }
            set { this.Command.Parameters["@pCalle"].Value = value; }
        }

        public string Colonia
        {
            get { return Utils.IsNull(this.Command.Parameters["@pColonia"].Value, ""); }
            set { this.Command.Parameters["@pColonia"].Value = value; }
        }

        public string Telefono
        {
            get { return Utils.IsNull(this.Command.Parameters["@pTelefono"].Value, ""); }
            set { this.Command.Parameters["@pTelefono"].Value = value; }
        }
    }
}