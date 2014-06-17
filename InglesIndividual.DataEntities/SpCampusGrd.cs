using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpCampusGrd : PagedStoredProcedure
    {
        public SpCampusGrd() : base("SpCampusGrd")
        {

            this.AddParameter("@pClaPais", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaEstado", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaCiudad", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pNomCampus", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pCalle", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pColonia", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pTelefono", System.Data.SqlDbType.VarChar, DBNull.Value);


        }

        public string NomCampus
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNomCampus"].Value, ""); }
            set { this.Command.Parameters["@pNomCampus"].Value = value; }
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
        public string Calle
        {
            get { return Utils.IsNull(this.Command.Parameters["@pCalle"].Value, ""); }
            set { this.Command.Parameters["@pCalle"].Value = value; }
        }

        public string Colonia
        {
            get { return Utils.IsNull(this.Command.Parameters["@pColonia"].Value, ""); }
            set { this.Command.Parameters["@pColonia"].Value = value; }
        }

        public string Telefono
        {
            get { return Utils.IsNull(this.Command.Parameters["@pTelefono"].Value, ""); }
            set { this.Command.Parameters["@pTelefono"].Value = value; }
        }
    }
}