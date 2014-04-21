using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpAmpliacionesUpd : StoredProcedure
    {
        public SpAmpliacionesUpd()
            : base("SpAmpliacionesUpd")
        {
            this.AddParameter("@pMatricula", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pVigencia", System.Data.SqlDbType.DateTime, DBNull.Value);
            this.AddParameter("@pComentarios", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pEstatus", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaNivel", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaLeccion", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pIdAmpliacion", System.Data.SqlDbType.Int, DBNull.Value);
            this.Command.Parameters["@pIdAmpliacion"].Direction = System.Data.ParameterDirection.Output;
    }

        public string Matricula
        {
            get { return Utils.IsNull(this.Command.Parameters["@pMatricula"].Value, ""); }
            set { this.Command.Parameters["@pMatricula"].Value = value; }
        }

        public int Vigencia
        {
            get { return Utils.IsNull(this.Command.Parameters["@pVigencia"].Value, 0); }
            set { this.Command.Parameters["@pVigencia"].Value = value; }
        }

        public string Comentarios
        {
            get { return Utils.IsNull(this.Command.Parameters["@pComentarios"].Value, ""); }
            set { this.Command.Parameters["@pComentarios"].Value = value; }
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
            get { return Utils.IsNull(this.Command.Parameters["@pClaLEccion"].Value, 0); }
            set { this.Command.Parameters["@pClaLeccion"].Value = value; }
        }

        public int IdAmpliacion
        {
            get { return Utils.IsNull(this.Command.Parameters["@pIdAmpliacion"].Value, 0); }
            set { this.Command.Parameters["@pIdAmpliacion"].Value = value; }
        }
    }
}
