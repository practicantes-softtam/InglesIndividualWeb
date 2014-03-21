using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
namespace InglesIndividual.DataEntities
{


    public class SpFwkModulosGrd : PagedStoredProcedure
    {


        public SpFwkModulosGrd()
            : base("spFwkModulosGrd")
        {

            this.AddParameter("@pNomModulo", System.Data.SqlDbType.VarChar, 50);

        }

        public string NomModulo
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNomPai"].Value, ""); }
            set { this.Command.Parameters["@pNomModulo"].Value = value; }
        }

    }
}

