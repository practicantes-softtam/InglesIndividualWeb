using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
namespace InglesIndividual.DataEntities
{


    public class SpFwkPerfilGrd : PagedStoredProcedure
    {


        public SpFwkPerfilGrd()
            : base("spFwkPerfilesGrd")
        {

            this.AddParameter("@pNomperfil", System.Data.SqlDbType.VarChar, "");

        }

        public string NomPerfil
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNomPerfil"].Value, ""); }
            set { this.Command.Parameters["@pNomPerfil"].Value = value; }
        }

    }
}