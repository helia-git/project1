using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using s2.DAL;


namespace s2.Controllers
{
    
    public class UserController : Controller
    {
        OfficeContext ctx = new OfficeContext();
        

        public IActionResult Index(string mail)
        { 
        var person = ctx.Users.FirstOrDefault(a => a.Username == mail);
            TempData["name"] = person.Name;
            return View();
        }
    }
}
