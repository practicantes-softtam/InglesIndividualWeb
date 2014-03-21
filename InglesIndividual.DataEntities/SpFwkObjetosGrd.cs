using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
namespace InglesIndividual.DataEntities
{


    public class SpFwkObjetosGrd : PagedStoredProcedure
    {


        public SpFwkObjetosGrd()
            : base("spFwkObjetosGrd")
        {

            this.AddParameter("@pNomObjeto", System.Data.SqlDbType.VarChar, "");

        }

        public string NomObjeto 
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNomObjeto"].Value, ""); }
            set { this.Command.Parameters["@pNomObjeto"].Value = value; }
        }

    }
}


