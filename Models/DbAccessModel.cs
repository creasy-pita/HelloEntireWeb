using HelloEntireWeb.Data;
using HelloEntireWeb.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace HelloEntireWeb.Models
{
    public class DbAccessModel
    {
        public IDbAccess dbAccess;

        public DbAccessModel(IDbAccess dbAccess)
        {
            this.dbAccess = dbAccess;
        }


        public DataSet GetBlogs()
        {
            string sql = "select BlogId ,Url  from Blogs ";
            DataSet ds = dbAccess.GetDataSet(sql);
            return ds;
        }
    }
}
