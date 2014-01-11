using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Framework
{
    public class DataTransaction
    {
        private string _connectionString;
        private SqlTransaction _tran;

        public string ConnectionString
        {
            get { return this._connectionString; }
        }

        internal SqlTransaction Transaction
        {
            get { return this._tran; }
        }

        public DataTransaction(string connectionString)
        {
            this._connectionString = connectionString;
            SqlConnection conn = new SqlConnection(this.ConnectionString);
            conn.Open();
            this._tran = conn.BeginTransaction();
        }

        public void Commit()
        {
            this._tran.Commit();
            this._tran.Dispose();
        }

        public void Rollback()
        {
            this._tran.Rollback();
            this._tran.Dispose();
        }
    }
}
