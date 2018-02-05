using HelloEntireWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloEntireWeb.Models
{
    public class BlogModel
    {
        public string info;

        public BlogModel(string info)
        {
            this.info = info;
        }

        public List<Blog> GetList()
        {
            List<Blog> list = new List<Blog>();
            //list.Add(new Blog { BlogId = 1, Url = "www.ddd.com" });
            //list.Add(new Blog { BlogId = 2, Url = "www.aaa.com" });
            //list.Add(new Blog { BlogId = 3, Url = "www.ccc.com" });
            return new List<Blog> { new Blog { BlogId = 1, Url = "www.aaa.com" }, new Blog { BlogId = 2, Url = "www.bbb.com" }, new Blog { BlogId = 3, Url = "www.ccc.com" } };
        }
    }
}
