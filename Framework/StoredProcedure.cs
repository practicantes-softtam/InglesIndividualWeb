using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Framework
{
    public class StoredProcedure
    {
        private string _name;
        private SqlCommand _cmd;
        private string _connStr;

        public StoredProcedure(string name)
        {
            this._name = name;
            this._cmd = new SqlCommand();
            this._cmd.Connection = new SqlConnection();
        }

        public string ConnectionString
        {
            get { return this._connStr; }
            set { this._connStr = value; }
        }
        public string Name
        {
            get { return this._name; }
        }

        public SqlCommand Command
        {
            get { return this._cmd; }
        }

        public void AddParameter(string paramName, SqlDbType type, object value)
        {
            this.AddParameter(paramName, type, 0, value);
        }

        public void AddParameter(string paramName, SqlDbType type, int size, object value)
        {
            this.Command.Parameters.Add(paramName, type, size).Value = value;
        }

        public object ExecuteScalar()
        {
            return this.ExecuteScalar(this.ConnectionString);
        }

        public object ExecuteScalar(string connectionString)
        {
            return this.ExecuteScalar(connectionString, null);
        }

        public object ExecuteScalar(DataTransaction tran)
        {
            return this.ExecuteScalar(null, tran);
        }

        private object ExecuteScalar(string connectionString, DataTransaction tran)
        {
            if (tran == null)
            {
                this.Command.Connection.ConnectionString = connectionString;
                this.Command.Connection.Open();
            }
            else
            {
                this.Command.Connection = tran.Transaction.Connection;
                this.Command.Transaction = tran.Transaction;
            }

            this.Command.CommandText = this.Name;
            this.Command.CommandType = CommandType.StoredProcedure;
            object ret = this.Command.ExecuteScalar();
            
            if (tran == null)
            {
                this.Command.Connection.Close();
            }
            
            return ret;
        }
        public int ExecuteNonQuery()
        {
            return this.ExecuteNonQuery(this.ConnectionString);
        }

        public int ExecuteNonQuery(string connectionString)
        {
            return this.ExecuteNonQuery(connectionString, null);
        }

        public int ExecuteNonQuery(DataTransaction tran)
        {
            return this.ExecuteNonQuery(null, tran);
        }

        private int ExecuteNonQuery(string connectionString, DataTransaction tran)
        {
            if (tran == null)
            {
                this.Command.Connection.ConnectionString = connectionString;
                this.Command.Connection.Open();
            }
            else
            {
                this.Command.Connection = tran.Transaction.Connection;
                this.Command.Transaction = tran.Transaction;
            }

            this.Command.CommandText = this.Name;
            this.Command.CommandType = CommandType.StoredProcedure;
            int ret = this.Command.ExecuteNonQuery();
            if (tran == null)
            {
                this.Command.Connection.Close();
            }
            return ret;
        }

        public DataTable GetDataTable()
        {
            return this.GetDataTable(this.ConnectionString);
        }

        public DataTable GetDataTable(string connectionString)
        {
            return this.GetDataTable(connectionString, null);
        }

        public DataTable GetDataTable(DataTransaction tran)
        {
            return this.GetDataTable(null, tran);
        }

        private DataTable GetDataTable(string connectionString, DataTransaction tran)
        {
            if (tran == null)
            {
                this.Command.Connection.ConnectionString = connectionString;
            }
            else
            {
                this.Command.Connection = tran.Transaction.Connection;
                this.Command.Transaction = tran.Transaction;
            }

            this.Command.CommandText = this.Name;
            this.Command.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = this.Command;
            DataTable dt = new DataTable();
            adp.Fill(dt);

            return dt;
        }
    }
}
