using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpCampusUpd : PagedStoredProcedure
    {
        public SpCampusUpd()
            : base("SpCampusUpd")
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

        }

        public int ClaCampus
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaCampus"].Value, 0); }
            set { this.Command.Parameters["@pClaCampus"].Value = value; }
        }

        public string NomCampus
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNomCampus"].Value, ""); }
            set { this.Command.Parameters["@pNomCampus"].Value = value; }
        }

        public string Calle
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaCalle"].Value, ""); }
            set { this.Command.Parameters["@pClaCalle"].Value = value; }
        }

        public string Colonia
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaColonia"].Value, ""); }
            set { this.Command.Parameters["@pClaColonia"].Value = value; }
        }

        public int CodigoPostal
        {
            get { return Utils.IsNull(this.Command.Parameters["@pCodigoPostal"].Value, 0); }
            set { this.Command.Parameters["@pCodigoPostal"].Value = value; }
        }

        public int ClaPais
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaPais"].Value, 0); }
            set { this.Command.Parameters["@pClaPais"].Value = value; }
        }

        public int ClaEstado
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaEstado"].Value, 0); }
            set { this.Command.Parameters["@pClaEstado"].Value = value; }
        }

        public int ClaCiudad
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaCiudad"].Value, 0); }
            set { this.Command.Parameters["@pClaCiudad"].Value = value; }
        }

        public string Telefono
        {
            get { return Utils.IsNull(this.Command.Parameters["@pTelefono"].Value, ""); }
            set { this.Command.Parameters["@pTelefono"].Value = value; }
        }

        public string DirectorGeneral
        {
            get { return Utils.IsNull(this.Command.Parameters["@pDirectorGeneral"].Value, ""); }
            set { this.Command.Parameters["@pDirectorGeneral"].Value = value; }
        }

        public string DirectorAdministrativo
        {
            get { return Utils.IsNull(this.Command.Parameters["@pDirectorAdministrativo"].Value, ""); }
            set { this.Command.Parameters["@pDirectorAdministrativo"].Value = value; }
        }


    }
}
