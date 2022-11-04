using entityTest2.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace entityTest2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DataContext dataContext = new DataContext(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


            User user = new User()
            {
                FirstName = "Aaron",
                LastName = "Lopez",
                Email = "aaronlopez@gmail.com",
                DateCreated = DateTime.Now,
            };
            dataContext.Users.Add(user);
            dataContext.SaveChanges();

            UserPermission userPermission = new UserPermission()
            {
                Name = "Admin",
                UserId = 1
            };
            dataContext.UserPermissions.Add(userPermission);
            dataContext.SaveChanges();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}