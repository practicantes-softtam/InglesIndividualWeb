using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpEmpleadosUpd : StoredProcedure
    {
         public SpEmpleadosUpd()
            : base("SpEmpleadosUpd")
        {
            this.AddParameter("@pApPaterno", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pApMaterno", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pNombre", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pSexo", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pClaCampuso", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaDepartamento", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaPuesto", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pCalle", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pColonia", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pCP", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pClaPais", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaEstado", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaCiudad", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pTelefono1", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pTelefono2", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pEmail", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pEsDocente", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pNombreCorto", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pBaja", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pFoto", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pObservaciones", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pClaEmpleado", System.Data.SqlDbType.Int, DBNull.Value);
           // this.Command.Parameters["@pClaEmpleado"].Direction = System.Data.ParameterDirection.Output;

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
             set { this.Command.Parameters["@pNombre"].Value = value; }
         }

         public string Sexo
         {
             get { return Utils.IsNull(this.Command.Parameters["@pSexo"].Value, ""); }
             set { this.Command.Parameters["@pSexo"].Value = value; }
         }

         public int ClaCampus
         {
             get { return Utils.IsNull(this.Command.Parameters["@pClaCampus"].Value, 0); }
             set { this.Command.Parameters["@pClaCampus"].Value = value; }
         }

         public int ClaDepartamento
         {
             get { return Utils.IsNull(this.Command.Parameters["@pClaDepartamento"].Value, 0); }
             set { this.Command.Parameters["@pClaDepartamento"].Value = value; }
         }

         public int ClaPuesto
         {
             get { return Utils.IsNull(this.Command.Parameters["@pClaPuesto"].Value, 0); }
             set { this.Command.Parameters["@pClaPuesto"].Value = value; }
         }

         public string Calle
         {
             get { return Utils.IsNull(this.Command.Parameters["@pCalle"].Value, ""); }
             set { this.Command.Parameters["@pCalle"].Value = value; }
         }

         public string Colonia
         {
             get { return Utils.IsNull(this.Command.Parameters["@pColonias"].Value, ""); }
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

         public int EsDocente
         {
             get { return Utils.IsNull(this.Command.Parameters["@pEsDocente"].Value, 0); }
             set { this.Command.Parameters["@pEsDocente"].Value = value; }
         }

         public string NombreCorto
         {
             get { return Utils.IsNull(this.Command.Parameters["@pNombreCorto"].Value, ""); }
             set { this.Command.Parameters["@pNombreCorto"].Value = value; }
         }

         public int Baja
         {
             get { return Utils.IsNull(this.Command.Parameters["@pBaja"].Value, 0); }
             set { this.Command.Parameters["@pBaja"].Value = value; }
         }

         public string Foto
         {
             get { return Utils.IsNull(this.Command.Parameters["@pFoto"].Value, ""); }
             set { this.Command.Parameters["@pFoto"].Value = value; }
         }

         public string Observaciones
         {
             get { return Utils.IsNull(this.Command.Parameters["@pObservaciones"].Value, ""); }
             set { this.Command.Parameters["@pObservaciones"].Value = value; }
         }

         public int ClaEmpleado
         {
             get { return Utils.IsNull(this.Command.Parameters["@pClaEmpleado"].Value, 0); }
             set { this.Command.Parameters["@pClaEmpleado"].Value = value; }
         }
    }
}
