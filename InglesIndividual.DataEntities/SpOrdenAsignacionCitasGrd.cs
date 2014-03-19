using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpOrdenAsignacionCitasGrd : PagedStoredProcedure
    {
        public SpOrdenAsignacionCitasGrd()
            : base("SpOrdenAsignacionCitasGrd")
        {
            this.AddParameter("@pClaCampus", System.Data.SqlDbType.Int, DBNull.Value);
            this.Command.Parameters["@pClaCampus"].Direction = System.Data.ParameterDirection.Output;
            this.AddParameter("@pClaProfesor", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pOrden", System.Data.SqlDbType.Int, DBNull.Value);

        }

        public int ClaCampus
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaCampus"].Value, 0); }
            set { this.Command.Parameters["@pClaCampus"].Value = value; }
        }

        public int ClaProfesor
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaProfesor"].Value, 0); }
            set { this.Command.Parameters["@pClaProfesor"].Value = value; }
        }

        public int Orden
        {
            get { return Utils.IsNull(this.Command.Parameters["@pOrden"].Value, 0); }
            set { this.Command.Parameters["@pOrden"].Value = value; }
        }


    }
}
