using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpAlumnosUpd : StoredProcedure
    {
        public SpAlumnosUpd()
            : base("SpAlumnosUpd")
        {
            this.AddParameter("@pApPaterno", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pApMaterno", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pNombre", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pSexo", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pCalle", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pColonia", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pCP", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaPais", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaEstado", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaCiudad", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pEmpresa", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pTelefono1", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pTelefono2", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pEmail", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pIngreso", System.Data.SqlDbType.DateTime, DBNull.Value);
            this.AddParameter("@pVigencia", System.Data.SqlDbType.DateTime, DBNull.Value);
            this.AddParameter("@pEstatus", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaCampus", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaNivel", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaLeccion", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pSuscriptor", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pClaAtendio", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pContrato", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pEspecial", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pObservaciones", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pFoto", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pFechaNacimiento", System.Data.SqlDbType.DateTime, DBNull.Value);
            this.AddParameter("@pTelefono3", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pMatricula", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.Command.Parameters["@pMatricula"].Direction = System.Data.ParameterDirection.Output;

        }

        public string ApPaterno
        {
            get { return Utils.IsNull(this.Command.Parameters["@pApPaterno"].Value, ""); }
            set { this.Command.Parameters["@pApPaterno"].Value = value; }
        }

        public string ApMaterno
        {
            get { return Utils.IsNull(this.Command.Parameters["@pApMaterno"].Value, ""); }
            set { this.Command.Parameters["@pApMaterno"].Value = value; }
        }

        public string Nombre
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNombre"].Value, ""); }
            set { this.Command.Parameters["@pApNombre"].Value = value; }
        }

        public string Sexo
        {
            get { return Utils.IsNull(this.Command.Parameters["@pSexo"].Value, ""); }
            set { this.Command.Parameters["@pSexo"].Value = value; }
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

        public int CP
        {
            get { return Utils.IsNull(this.Command.Parameters["@pCP"].Value, 0); }
            set { this.Command.Parameters["@pCP"].Value = value; }
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

        public string Empresa
        {
            get { return Utils.IsNull(this.Command.Parameters["@pEmpresa"].Value, ""); }
            set { this.Command.Parameters["@pEmpresa"].Value = value; }
        }

        public string Telefono1
        {
            get { return Utils.IsNull(this.Command.Parameters["@pTelefono1"].Value, ""); }
            set { this.Command.Parameters["@pTelefono1"].Value = value; }
        }

        public string Telefono2
        {
            get { return Utils.IsNull(this.Command.Parameters["@pTelefono2"].Value, ""); }
            set { this.Command.Parameters["@pTelefono2"].Value = value; }
        }

        public string Email
        {
            get { return Utils.IsNull(this.Command.Parameters["@pEmail"].Value, ""); }
            set { this.Command.Parameters["@pEmail"].Value = value; }
        }

        public DateTime Ingreso
        {
            get { return Utils.IsNull(this.Command.Parameters["@pIngreso"].Value, DateTime.Now); }
            set { this.Command.Parameters["@pIngreso"].Value = value; }
        }

        public DateTime Vigencia
        {
            get { return Utils.IsNull(this.Command.Parameters["@pVigencia"].Value, DateTime.Now); }
            set { this.Command.Parameters["@pVigencia"].Value = value; }
        }

        public int Estatus
        {
            get { return Utils.IsNull(this.Command.Parameters["@pEstatus"].Value, 0); }
            set { this.Command.Parameters["@pEstatus"].Value = value; }
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
            get { return Utils.IsNull(this.Command.Parameters["@pClaLeccion"].Value, 0); }
            set { this.Command.Parameters["@pClaLeccion"].Value = value; }
        }

        public string Suscriptor
        {
            get { return Utils.IsNull(this.Command.Parameters["@pSuscriptor"].Value, ""); }
            set { this.Command.Parameters["@pSuscriptor"].Value = value; }
        }

        public int ClaAtendio
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaAtendio"].Value, 0); }
            set { this.Command.Parameters["@pClaAtendio"].Value = value; }
        }

        public string Contrato
        {
            get { return Utils.IsNull(this.Command.Parameters["@pContrato"].Value, ""); }
            set { this.Command.Parameters["@pContrato"].Value = value; }
        }

        public int Especial
        {
            get { return Utils.IsNull(this.Command.Parameters["@pEspecial"].Value, 0); }
            set { this.Command.Parameters["@pEspecial"].Value = value; }
        }


        public string Observaciones
        {
            get { return Utils.IsNull(this.Command.Parameters["@pObservaciones"].Value, ""); }
            set { this.Command.Parameters["@pObservaciones"].Value = value; }
        }


        public int Foto
        {
            get { return Utils.IsNull(this.Command.Parameters["@pFoto"].Value, 0); }
            set { this.Command.Parameters["@pFoto"].Value = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return Utils.IsNull(this.Command.Parameters["@pFechaNacimiento"].Value, DateTime.Now); }
            set { this.Command.Parameters["@pFechaNacimiento"].Value = value; }
        }

        public string Telefono3
        {
            get { return Utils.IsNull(this.Command.Parameters["@pTelefono3"].Value, ""); }
            set { this.Command.Parameters["@pTelefono3"].Value = value; }
        }

        public string Matricula
        {
            get { return Utils.IsNull(this.Command.Parameters["@pMatricula"].Value, ""); }
            set { this.Command.Parameters["@pMatricula"].Value = value; }
        }
    }
}
