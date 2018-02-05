using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace HelloEntireWeb.Services
{
    public class MySqlDbAccess : IDbAccess
    {
        public bool IsTran
        {
            get;
            set;
        }

        public bool IsOpen
        {
            get;
            set;
        }

        public IDbConnection conn
        {
            get;
            set;
        }

        public IDbTransaction tran
        {
            get;
            set;
        }

        public string ConnectionStr
        {
            get;
            set;
        }

        public bool IsKeepConnect
        {
            get;
            set;
        }

        public MySqlDbAccess(string ConnectionStr)
        {
            this.ConnectionStr = ConnectionStr;
            this.conn = new MySqlConnection(this.ConnectionStr);
        }

        public void Open()
        {
            if (this.conn.State != ConnectionState.Open)
            {
                this.conn.Open();
                IsOpen = true;
            }
        }
        public void Close()
        {
            IsOpen = false;
            IsTran = false;
            IsKeepConnect = false;
            this.conn.Close();
        }

        public DataSet GetDataSet(string sql)
        {
            try
            {
                Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, (MySqlConnection)this.conn);
                if (IsTran) adapter.SelectCommand.Transaction = (MySqlTransaction)this.tran;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (!IsTran && !IsKeepConnect)
                {
                    Close();
                }
            }
        }

        public bool Insert(string sqlCom)
        {
            Console.WriteLine(" MySqlDbAccess 's insert");
            return true;
        }
    }
}
