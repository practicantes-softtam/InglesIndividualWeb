using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Framework
{
    public class SqlQuery
    {
        private string _query;
        private SqlCommand _cmd;
        private string _connStr;
        CommandType _type;

        public SqlQuery(string query) : this(query, CommandType.Text)
        {
        }

        public SqlQuery(string query, CommandType type)
        {
            this._query = query;
            this._type = type;
            this._cmd = new SqlCommand();
            this._cmd.Connection = new SqlConnection();
        }

        public string ConnectionString
        {
            get { return this._connStr; }
            set { this._connStr = value; }
        }

        public string Query
        {
            get { return this._query; }
        }

        public SqlCommand Command
        {
            get { return this._cmd; }
        }

        public CommandType Type
        {
            get { return this._type; }
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

            this.Command.CommandText = this.Query;
            this.Command.CommandType = this.Type;
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

            this.Command.CommandText = this.Query;
            this.Command.CommandType = this.Type;
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

            this.Command.CommandText = this.Query;
            this.Command.CommandType = this.Type;

            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = this.Command;
            DataTable dt = new DataTable();
            adp.Fill(dt);

            return dt;
        }
    }
}
