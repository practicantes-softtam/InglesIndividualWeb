using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpLeccionesUpd : PagedStoredProcedure
    {
        public SpLeccionesUpd()
            : base("SpLeccionesUpd")
        {
            this.AddParameter("@pClaCampus", System.Data.SqlDbType.Int, DBNull.Value);
            this.Command.Parameters["@pClaCampus"].Direction = System.Data.ParameterDirection.Output;
            this.AddParameter("@pNomCampus", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pCalle", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pColonia", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pCodigoPostal", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaPais", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaEstado", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaCiudad", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pTelefono", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pDirectorGeneral", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pCirectorAdministrativo", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pClaLeccion", System.Data.SqlDbType.Int, DBNull.Value);
            this.Command.Parameters["@pClaLeccion"].Direction = System.Data.ParameterDirection.Output;
            this.AddParameter("@pClaNivel", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pNomLeccion", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pEsReview", System.Data.SqlDbType.Int, DBNull.Value);
         }

        public int ClaLeccion
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaLeccion"].Value, 0); }
            set { this.Command.Parameters["@pClaLeccion"].Value = value; }
        }
        public int ClaNivel
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaNivel"].Value, 0); }
            set { this.Command.Parameters["@pClaNivel"].Value = value; }
        }
        public string NomLeccion
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNomLeccion"].Value, ""); }
            set { this.Command.Parameters["@pNomLeccion"].Value = value; }
        }
        public int EsReview
        {
            get { return Utils.IsNull(this.Command.Parameters["@pEsReview"].Value, 0); }
            set { this.Command.Parameters["@pEsReview"].Value = value; }
        }



    }
}
