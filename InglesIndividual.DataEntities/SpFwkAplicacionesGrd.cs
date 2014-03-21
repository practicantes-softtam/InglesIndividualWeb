using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
namespace InglesIndividual.DataEntities
{


    public class SpFwkAplicacionesGrd : PagedStoredProcedure
    {


        public SpFwkAplicacionesGrd() : base("spFwkAplicacionesGrd")
        {

            this.AddParameter("@pNomAplicacion", System.Data.SqlDbType.VarChar, 50);

        }

        public string NomAplicacion
        {
            get { return Utils.IsNull(this.Command.Parameters["@picacion"].Value, ""); }
            set { this.Command.Parameters["@pNomAplicacion"].Value = value; }
        }

    }
}
