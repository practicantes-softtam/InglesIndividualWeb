using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpLeccionesGrd : PagedStoredProcedure
    {
        public SpLeccionesGrd()
            : base("SpLeccionesGrd")
        {
            this.AddParameter("@pNomLeccion", System.Data.SqlDbType.VarChar, "");
                        
        }

        public string NomLeccion
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNomLeccion"].Value, ""); }
            set { this.Command.Parameters["@pNomLeccion"].Value = value; }
        }

    }
}