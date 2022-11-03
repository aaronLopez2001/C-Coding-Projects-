using CarInsurance.Models;
using CarInsurance.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult CalculateQuote()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insurees = db.Insurees;
                var insureeVms = new List<InsureeVm>();
                foreach (var insuree in insurees)
                {
                    var insureeVm = new InsureeVm();
                    insureeVm.FirstName = insuree.FirstName;
                    insureeVm.LastName = insuree.LastName;
                    insureeVm.EmailAddress = insuree.EmailAddress;
                    insureeVm.DateOfBirth = insuree.DateOfBirth;
                    insureeVm.CarYear = insuree.CarYear;
                    insureeVm.CarMake = insuree.CarMake;
                    insureeVm.CarModel = insuree.CarModel;
                    insureeVm.CoverageType = insuree.CoverageType;
                    
                    

                    int age = insuree.DateOfBirth.Year;
                    int year = DateTime.Now.Year;
                    int myAge = year - age;
                    //Checks age
                    if(myAge < 18)
                    {
                        insuree.Quote =+ 150.00m;
                    }
                    else if(myAge >= 19 && myAge <= 25)
                    {
                        insuree.Quote = +100.00m;
                    }
                    else
                    {
                        insuree.Quote += 75.00m;
                    }
                    //Checks the year of the car
                    if (insuree.CarYear < 2000)
                    {
                        insuree.Quote += 25.00m;
                    }
                    else if(insuree.CarYear > 2015)
                    {
                        insuree.Quote += 25.00m;
                    }
                    if(insuree.CarMake == "porsche" || insuree.CarMake == "Porsche" || insuree.CarMake == "PORSCHE" && insuree.CarModel == "911 Carrera") 
                    {
                        insuree.Quote += 25.00m;
                    }
                    if(insuree.SpeedingTickets > 0)
                    {
                        insuree.Quote = insuree.SpeedingTickets * 10.00m;
                    }
                    if(insuree.DUI == true)
                    {
                        insuree.Quote = insuree.Quote * 0.25m;
                    }
                    if (insuree.CoverageType == true)
                    {
                        insuree.Quote = insuree.Quote * 0.50m;
                    }

                    decimal totalQuote = insuree.Quote;

                    insureeVm.Quote = totalQuote;
                    insureeVms.Add(insureeVm);


                    
                   
                }
            }
            

                return RedirectToAction("insuree");


        }



    }
}
