using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpOrdenAsignacionCitasDel : StoredProcedure
    {
        public SpOrdenAsignacionCitasDel() : base("SpOrdenAsignacionCitasDel")
        {
            this.AddParameter("@pClaCampus", System.Data.SqlDbType.Int, 0);
            this.AddParameter("@pClaProfesor", System.Data.SqlDbType.Int, 0);
            this.AddParameter("@pOrden", System.Data.SqlDbType.Int, 0);
            this.Command.Parameters["@pClaCampus"].Direction = System.Data.ParameterDirection.Output;
            this.Command.Parameters["@pClaProfesor"].Direction = System.Data.ParameterDirection.Output;
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