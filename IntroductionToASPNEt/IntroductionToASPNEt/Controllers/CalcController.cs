using IntroductionToASPNEt.Helpers;
using IntroductionToASPNEt.Models;
using IntroductionToASPNEt.Resources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web.Mvc;

namespace IntroductionToASPNEt.Controllers
{
    public class CalcController : Controller
    {
        public static List<string> Results = new List<string>();

        const int DefaultX = 3;
        const int DefaultY = 32;
        const string DefaultResult = "No data";

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OperationCalculation()
        {
            return View(new CalcModel() { X = DefaultX, Y = DefaultY});
        }

        [HttpPost]
        public ActionResult OperationCalculation(CalcModel model)
        {
            double result = 0;

            try
            {
                switch (model.Op)
                {
                    case Operation.Add:
                        result = model.X + model.Y;
                        break;

                    case Operation.Subtraction:
                        result = model.X - model.Y;
                        break;

                    case Operation.Multiplication:
                        result = model.X * model.Y;
                        break;

                    case Operation.Divide:
                        if (model.Y == 0)
                        {
                            throw new DivideByZeroException();
                        }
                        result = (double)model.X / model.Y;
                        break;

                    case Operation.Power:
                        result = Math.Pow(Convert.ToDouble(model.X), Convert.ToDouble(model.Y));
                        break;

                    case Operation.Logarithm:
                        if (model.Y <= 1)
                        {
                            throw new Exception();
                        }
                        result = Math.Log(Convert.ToDouble(model.X), Convert.ToDouble(model.Y));
                        break;
                }
                model.Result = result.ToString();

                Results.Add($"{DateTime.Now.ToString("d MMM HH:mm", CultureInfo.CreateSpecificCulture("en-US"))}   |   {CalcResources.x} {model.Op.DisplayName()} {CalcResources.y} = {result}\n");
            }            
            catch(DivideByZeroException)
            {
                Results.Add("Divide by zero! Change Y value");
            }
            catch(Exception)
            {
                Results.Add("Incorrcet base of logarithm! Y must be more than one");
            }

            return View(model);
        }
    }
}