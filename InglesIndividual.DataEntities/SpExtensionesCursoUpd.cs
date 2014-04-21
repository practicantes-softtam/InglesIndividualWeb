using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
namespace InglesIndividual.DataEntities
{
    public class SpExtensionesCursoUpd : StoredProcedure
    {
         public SpExtensionesCursoUpd()
            : base("SpExtensionesCursoUpd")
        {
            this.AddParameter("@pClaCampus", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pMatricula", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pFechaIni", System.Data.SqlDbType.DateTime, DBNull.Value);
            this.AddParameter("@pFechaFin", System.Data.SqlDbType.DateTime, DBNull.Value);
            this.AddParameter("@pComentarios", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pEstatus", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaNivel", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaLeccion", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pTipoRegistro", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pIdRegistro", System.Data.SqlDbType.Int, DBNull.Value);
            this.Command.Parameters["@pIdRegistro"].Direction = System.Data.ParameterDirection.Output;
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

         public int FechaIni
         {
             get { return Utils.IsNull(this.Command.Parameters["@pFechaIni"].Value, 0); }
             set { this.Command.Parameters["@pFechaIni"].Value = value; }
         }

         public int FechaFin
         {
             get { return Utils.IsNull(this.Command.Parameters["@pFechaFins"].Value, 0); }
             set { this.Command.Parameters["@pFechaFin"].Value = value; }
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
             get { return Utils.IsNull(this.Command.Parameters["@pClaLeccion"].Value, 0); }
             set { this.Command.Parameters["@pClaLeccion"].Value = value; }
         }

         public int TipoRegistro
         {
             get { return Utils.IsNull(this.Command.Parameters["@pTipoRegistro"].Value, 0); }
             set { this.Command.Parameters["@pTipoRegistro"].Value = value; }
         }

         public int IdRegistro
         {
             get { return Utils.IsNull(this.Command.Parameters["@pIdRegistro"].Value, 0); }
             set { this.Command.Parameters["@pIdRegistro"].Value = value; }
         }
    }
}
