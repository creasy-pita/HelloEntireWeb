using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace HelloEntireWeb.Services
{
    public class OracleDbAccess : IDbAccess
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
            throw new NotImplementedException("this method is not implement");
        }

        public bool Insert(string sqlCom)
        {
            Console.WriteLine(" OracleDbAccess 's insert");
            return true;
        }
    }
}
