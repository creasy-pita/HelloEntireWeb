using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace HelloEntireWeb.Services
{
    public interface IDbAccess
    {
        bool IsTran
        {
            get;
            set;
        }

        bool IsOpen
        {
            get;
            set;
        }

        IDbConnection conn
        {
            get;
            set;
        }

        IDbTransaction tran
        {
            get;
            set;
        }

        string ConnectionStr
        {
            get;
            set;
        }

        bool IsKeepConnect
        {
            get;
            set;
        }

        void Open();
        void Close();
        DataSet GetDataSet(string sql);

        bool Insert(string sqlCom);
    }
}
