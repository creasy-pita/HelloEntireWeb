using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloEntireWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloEntireWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            IList<string> MessageList = new List<string>();
            MessageList.Add("aaa");
            MessageList.Add("bbb");
            MessageList.Add("cccc");
            MessageList.Add("dddd");
            BloggingContext bloggingContext = new BloggingContext();
            BlogModel model = new BlogModel(bloggingContext);


            return View("Index", model);
        }
    }
}