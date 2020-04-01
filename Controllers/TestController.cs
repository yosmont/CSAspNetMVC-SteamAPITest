using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test1.Models;

namespace test1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index() // /Test/Index
        {
            return View();
        }
        
        public ActionResult GetGame(int ID)
        {
            return Json( new { game = new SteamGameModel(ID) });
        }
    }
}