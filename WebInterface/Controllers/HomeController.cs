using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calculator.TwoArgument;

namespace WebInterface.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operation = new List<SelectListItem>()
            {
                new SelectListItem() {Text = "+", Value = "button_plus"},
                new SelectListItem() {Text = "-", Value = "button_minus"},
                new SelectListItem() {Text = "*", Value = "button_multiply"},
                new SelectListItem() {Text = "/", Value = "button_divide"},
                new SelectListItem() {Text = "x^y", Value = "xToPower"},
                new SelectListItem() {Text = "x^(1/y)", Value = "xTo1mY"},
                new SelectListItem() {Text = "Average", Value = "Average"}

            };
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

        public ActionResult Calculator(double first,double second, string operation)
        {
            var calc = TwoArgumentsFactory.CreateCalculator(operation);
            double result = calc.Calculate(first, second);
            return View(result);
        }
    }
}