
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
namespace InglesIndividual.DataEntities
{


    public class SpFwkPermisosPerfilGrd : PagedStoredProcedure
    {


        public SpFwkPermisosPerfilGrd()
            : base("spFwkPermisosPerfilGrd")
        {

            this.AddParameter("@pPermitir", System.Data.SqlDbType.Int, 0);

        }

        public int Permitir
        {
            get { return Utils.IsNull(this.Command.Parameters["@pPermitir"].Value, 0); }
            set { this.Command.Parameters["@pPeritir"].Value = value; }




        }
    }
}


