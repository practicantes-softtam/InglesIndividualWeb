using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpKardexUpd : PagedStoredProcedure
    {
        public SpKardexUpd() : base("SpKardexUpd")
        {
            this.AddParameter("@pIdCalificacion", System.Data.SqlDbType.Int, DBNull.Value);
            this.Command.Parameters["@pIdCalificacion"].Direction = System.Data.ParameterDirection.Output;
            this.AddParameter("@pMatricula", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaCampus", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaNivel", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaLeccion", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaProfesor", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pCalificacion", System.Data.SqlDbType.Decimal, DBNull.Value);
            this.AddParameter("@pTipoClase", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pFecha", System.Data.SqlDbType.SmallDateTime, DBNull.Value);
            this.AddParameter("@pClaCalificacion", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pIdCita", System.Data.SqlDbType.VarChar, DBNull.Value);

        }

        public int IdCalificacion
        {
            get { return Utils.IsNull(this.Command.Parameters["@pIdCalificacion"].Value, 0); }
            set { this.Command.Parameters["@pIdCalificacion"].Value = value; }
        }

        public string Matricula
        {
            get { return Utils.IsNull(this.Command.Parameters["@pMatricula"].Value, ""); }
            set { this.Command.Parameters["@pMatricula"].Value = value; }
        }

        public int ClaCampus
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaCampus"].Value, 0); }
            set { this.Command.Parameters["@pClaCampus"].Value = value; }
        }

        public int ClaNivel
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaNivel"].Value, 0); }
            set { this.Command.Parameters["@pClaNivel"].Value = value; }
        }

        public int ClaLeccion
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaNivel"].Value, 0); }
            set { this.Command.Parameters["@pClaNivel"].Value = value; }
        }

        public int ClaProfesor
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaProfesor"].Value, 0); }
            set { this.Command.Parameters["@pClaProfesor"].Value = value; }
        }

        public decimal Calificacion
        {
            get { return Utils.IsNull(this.Command.Parameters["@pCalificacion"].Value, 0); }
            set { this.Command.Parameters["@pCalificacion"].Value = value; }
        }

        public int TipoClase
        {
            get { return Utils.IsNull(this.Command.Parameters["@pTipoClase"].Value, 0); }
            set { this.Command.Parameters["@pTipoClase"].Value = value; }
        }

        public int ClaCalificacion
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaCalificacion"].Value, 0); }
            set { this.Command.Parameters["@pClaCalificacion"].Value = value; }
        }

        public int IdCita
        {
            get { return Utils.IsNull(this.Command.Parameters["@pIdCita"].Value, 0); }
            set { this.Command.Parameters["@pIdCita"].Value = value; }
        }

       }
}
