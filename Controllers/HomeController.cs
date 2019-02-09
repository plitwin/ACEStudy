using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ACEStudy.Models;

namespace ACEStudy.Controllers
{
    public class HomeController : Controller
    {
        //private string surveyUrl = "https://cdsweb07.fhcrc.org/redcap/surveys/?s=DDNC9RAETN";
        private string surveyUrl = "http://theacestudy.org/home/surveyplaceholder";

        public IActionResult Index()
        {
            ViewBag.SurveyUrl = surveyUrl;
            return View();
        }

        public IActionResult About()
        {
            ViewBag.SurveyUrl = surveyUrl;
            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.SurveyUrl = surveyUrl;
            return View();
        }
        
        public IActionResult Eligibility()
        {
            ViewBag.SurveyUrl = surveyUrl;            
            return View();
        }

        
        public IActionResult Team()
        {
            ViewBag.SurveyUrl = surveyUrl;            
            return View();
        }

        public IActionResult SurveyPlaceholder()
        {
            ViewBag.SurveyUrl = surveyUrl;            
            return View();
        } 

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
