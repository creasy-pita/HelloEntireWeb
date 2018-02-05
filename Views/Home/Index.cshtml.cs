using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloEntireWeb.Views
{
    public class IndexModel : PageModel
    {
        public IList<string> MessageList;

        public void OnGet()
        {
            MessageList = new List<string>();

        }
    }
}