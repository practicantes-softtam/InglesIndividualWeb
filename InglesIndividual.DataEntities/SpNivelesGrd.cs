using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpNivelesGrd : PagedStoredProcedure
    {

        public SpNivelesGrd() : base("spNivelesGrd")
        {
            this.AddParameter("@pClaNivel", System.Data.SqlDbType.Int, 0);
            this.Command.Parameters["@pClaNivel"].Direction = System.Data.ParameterDirection.Output;
            this.AddParameter("@pNomNivel", System.Data.SqlDbType.VarChar, "");
            this.AddParameter("@pClubConversacion", System.Data.SqlDbType.Int, 0);
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

        public int ClubConversacion
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClubConversacion"].Value, 0); }
            set { this.Command.Parameters["@pClubConversacion"].Value = value; }
        }
    }
}

