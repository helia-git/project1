using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using DocumentFormat.OpenXml.Office.CustomXsn;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using s2.DAL;





namespace s2.Controllers
{
    
    public class AccountController : Controller
    {
        OfficeContext ctx = new OfficeContext();
        public IActionResult Login()
        {
           
            return View();
        }

        public IActionResult SignUp()
        { 
            return View();
        }
        public IActionResult Save(string email, string password, string name, string age)
        {
            Add(email, password, name, age);
            return RedirectToAction("Login");
        }

        public IActionResult check(string email , string password)
        {
            if(ctx.Users.Any(a=>a.Username==email && a.Passsword==password))
            {
                
                //RedirectToAction("~/user/index");
                return RedirectToAction("Index", "User",new {mail=email });
            }
            return RedirectToAction("Login");
        }

        public void Add(string email, string password, string name, string age)
        {
            User person = new User { Username = email, Passsword = password, Name = name, Age = int.Parse(age) };
            ctx.Users.Add(person);
            ctx.SaveChanges();
        }
        //public void GetName(string email)
        //{
            

            
            


            /*ctx.AddJavaScriptVariable("GetName", person.Name);

            object p = ctx.AddJavaScriptFunction("GetName");*/


        //}

        //public ActionResult SetName(string email)
        //{
        //    var person = ctx.Users.FirstOrDefault(a => a.Username == email);

        //    return View(person.Name);
        //}


        //private object AddJavaScriptFunction(string v)
        //{
        //    throw new NotImplementedException();
        //}
    }
   
}
