using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using HelloEntireWeb.Models;
using HelloEntireWeb.Services;
using Microsoft.AspNetCore.Mvc;

namespace HelloEntireWeb.Controllers
{
    //[Route("/Home")]
    public class HomeController : Controller
    {
        public DbAccessModel dbAccessModel;

        public HomeController(DbAccessModel dbAccessModel)
        {
            this.dbAccessModel = dbAccessModel;
        }

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
        public IActionResult Index1()
        {
            return View("/Views/Home/Index1.cshtml", dbAccessModel);
        }
    }
}