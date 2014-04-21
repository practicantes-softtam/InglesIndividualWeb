using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpCitasUpd : StoredProcedure
    {
         public SpCitasUpd()
            : base("SpCitasUpd")
        {
            this.AddParameter("@pClaCampus", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pMatricula", System.Data.SqlDbType.VarChar, DBNull.Value);
             this.AddParameter("@pClaProfesor", System.Data.SqlDbType.Int, DBNull.Value);
             this.AddParameter("@pFechaHora", System.Data.SqlDbType.DateTime, DBNull.Value);
             this.AddParameter("@pTipoClase", System.Data.SqlDbType.Int, DBNull.Value);
             this.AddParameter("@pEstatus", System.Data.SqlDbType.Int, DBNull.Value);
             this.AddParameter("@pClaNivel", System.Data.SqlDbType.Int, DBNull.Value);
             this.AddParameter("@pClaLeccion", System.Data.SqlDbType.Int, DBNull.Value);
             this.AddParameter("@pFechaHoraOriginal", System.Data.SqlDbType.DateTime, DBNull.Value);
             this.AddParameter("@pObservaciones", System.Data.SqlDbType.VarChar, DBNull.Value);
             this.AddParameter("@pModManual", System.Data.SqlDbType.Int, DBNull.Value);
             this.AddParameter("@pFechaHoraAsistencia", System.Data.SqlDbType.DateTime, DBNull.Value);
             this.AddParameter("@pAprobo", System.Data.SqlDbType.Int, DBNull.Value);
             this.AddParameter("@pIdCita", System.Data.SqlDbType.Int, DBNull.Value);
            this.Command.Parameters["@pIdCita"].Direction = System.Data.ParameterDirection.Output;
    }

         public int ClaCampus
         {
             get { return Utils.IsNull(this.Command.Parameters["@pClaCampus"].Value, 0); }
             set { this.Command.Parameters["@pClaCampus"].Value = value; }
         }

         public string Matricula
         {
             get { return Utils.IsNull(this.Command.Parameters["@pMatricula"].Value, ""); }
             set { this.Command.Parameters["@pMatricula"].Value = value; }
         }

         public int ClaProfesor
         {
             get { return Utils.IsNull(this.Command.Parameters["@pClaProfesor"].Value, 0); }
             set { this.Command.Parameters["@pClaProfesor"].Value = value; }
         }

        public int FechaHora
         {
             get { return Utils.IsNull(this.Command.Parameters["@pFechaHora"].Value, 0); }
             set { this.Command.Parameters["@pFechaHora"].Value = value; }
         }

        public int TipoClase
        {
            get { return Utils.IsNull(this.Command.Parameters["@pTipoClase"].Value, 0); }
            set { this.Command.Parameters["@pTipoClase"].Value = value; }
        }

        public int Estatus
        {
            get { return Utils.IsNull(this.Command.Parameters["@pEstatus"].Value, 0); }
            set { this.Command.Parameters["@pEstatus"].Value = value; }
        }

        public int ClaNivel
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaNivel"].Value, 0); }
            set { this.Command.Parameters["@pClaNivel"].Value = value; }
        }

        public int ClaLeccion
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaLeccion"].Value, 0); }
            set { this.Command.Parameters["@pClaLeccion"].Value = value; }
        }

        public int FechaHoraOriginal
        {
            get { return Utils.IsNull(this.Command.Parameters["@pFechaHoraOriginal"].Value, 0); }
            set { this.Command.Parameters["@pFechaHoraOriginal"].Value = value; }
        }

        public string Observaciones
        {
            get { return Utils.IsNull(this.Command.Parameters["@pObservaciones"].Value, ""); }
            set { this.Command.Parameters["@pObservaciones"].Value = value; }
        }

        public int ModManual
        {
            get { return Utils.IsNull(this.Command.Parameters["@pModManual"].Value, 0); }
            set { this.Command.Parameters["@pModManual"].Value = value; }
        }

        public int FechaHoraAsistencia
        {
            get { return Utils.IsNull(this.Command.Parameters["@pFechaHoraAsistencia"].Value, 0); }
            set { this.Command.Parameters["@pFechaHoraAsistencia"].Value = value; }
        }

        public int Aprobo
        {
            get { return Utils.IsNull(this.Command.Parameters["@pAprobo"].Value, 0); }
            set { this.Command.Parameters["@pAprobo"].Value = value; }
        }

        public int IdCita
        {
            get { return Utils.IsNull(this.Command.Parameters["@pIdCita"].Value, 0); }
            set { this.Command.Parameters["@pIdCita"].Value = value; }
        }
    }
}
