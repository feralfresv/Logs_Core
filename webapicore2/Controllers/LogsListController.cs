using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webapicore2.Models;

namespace webapicore2.Controllers
{
    public class LogsListController : Controller
    {
        Models.Team4RMContext Team4RMEntities = new Models.Team4RMContext();

        // GET: LogsList
        public ActionResult Index()
        {
            return View(Team4RMEntities.Log.ToList());
        }
    }
}