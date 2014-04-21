using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpFwkHorarioMaestrosIns : StoredProcedure
    {
        public SpFwkHorarioMaestrosIns() : base("SpHorarioMaestrosIns")
        {

            this.AddParameter("@pClaEmpleado", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaCampus", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaHorario", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pLun", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pMar", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pMie", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pJue", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pVie", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pSab", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pDom", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pOrdenLun", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pOrdenMar", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pOrdenMie", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pOrdenJue", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pOrdenVie", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pOrdenSab", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pOrdenDom", System.Data.SqlDbType.Int, DBNull.Value);
            this.Command.Parameters["@pClaEmpleado"].Direction = System.Data.ParameterDirection.Output;
            this.Command.Parameters["@pClaCampus"].Direction = System.Data.ParameterDirection.Output;
            this.Command.Parameters["@pClaHorario"].Direction = System.Data.ParameterDirection.Output;
            
        }

        public int ClaEmpleado
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaEmpleado"].Value, 0); }
            set { this.Command.Parameters["@pClaEmpleado"].Value = value; }
        }

        public int ClaCampus
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaCampus"].Value, 0); }
            set { this.Command.Parameters["@ClaCampus"].Value = value; }
        }

        public int ClaHorario
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaHorario"].Value, 0); }
            set { this.Command.Parameters["@ClaHorario"].Value = value; }
        }

        public int Lun
        {
            get { return Utils.IsNull(this.Command.Parameters["@pLun"].Value, 0); }
            set { this.Command.Parameters["@pLun"].Value = value; }
        }

        public int Mar
        {
            get { return Utils.IsNull(this.Command.Parameters["@pMar"].Value, 0); }
            set { this.Command.Parameters["@pMar"].Value = value; }
        }

        public int Mie
        {
            get { return Utils.IsNull(this.Command.Parameters["@pMie"].Value, 0); }
            set { this.Command.Parameters["@pMie"].Value = value; }
        }

        public int Jue
        {
            get { return Utils.IsNull(this.Command.Parameters["@pJue"].Value, 0); }
            set { this.Command.Parameters["@pJue"].Value = value; }
        }

        public int Vie
        {
            get { return Utils.IsNull(this.Command.Parameters["@pVie"].Value, 0); }
            set { this.Command.Parameters["@pVie"].Value = value; }
        }

        public int Sab
        {
            get { return Utils.IsNull(this.Command.Parameters["@pLun"].Value, 0); }
            set { this.Command.Parameters["@pLun"].Value = value; }
        }

        public int Dom
        {
            get { return Utils.IsNull(this.Command.Parameters["@pDom"].Value, 0); }
            set { this.Command.Parameters["@pDom"].Value = value; }
        }


        public int OrdenLun
        {
            get { return Utils.IsNull(this.Command.Parameters["@pOrdenLun"].Value, 0); }
            set { this.Command.Parameters["@pOrdenLun"].Value = value; }
        }

        public int OrdenMar
        {
            get { return Utils.IsNull(this.Command.Parameters["@pOrdenMar"].Value, 0); }
            set { this.Command.Parameters["@pOrdenMar"].Value = value; }
        }

        public int OrdenMie
        {
            get { return Utils.IsNull(this.Command.Parameters["@pOrdenMie"].Value, 0); }
            set { this.Command.Parameters["@pOrdenMie"].Value = value; }
        }

        public int OrdenJue
        {
            get { return Utils.IsNull(this.Command.Parameters["@pJue"].Value, 0); }
            set { this.Command.Parameters["@pOrdenJue"].Value = value; }
        }

        public int OrdenVie
        {
            get { return Utils.IsNull(this.Command.Parameters["@pOrdenVie"].Value, 0); }
            set { this.Command.Parameters["@pOrdenVie"].Value = value; }
        }

        public int OrdenSab
        {
            get { return Utils.IsNull(this.Command.Parameters["@pOrdenSab"].Value, 0); }
            set { this.Command.Parameters["@pOrdenSab"].Value = value; }
        }

        public int OrdenDom
        {
            get { return Utils.IsNull(this.Command.Parameters["@pOrdenDom"].Value, 0); }
            set { this.Command.Parameters["@pOrdenDom"].Value = value; }
        }
    }
}



