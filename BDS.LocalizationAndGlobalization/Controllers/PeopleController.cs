using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BDS.LocalizationAndGlobalization.Models;

namespace BDS.LocalizationAndGlobalization.Controllers
{
    public class PeopleController : Controller
    {
        public ActionResult Edit(int id=0)
        {
            var model = new EditPersonModel();
            model.BirthDate = new DateTime(2015, 3, 25, 0, 0, 0);
            model.Salary = 5000.1234m;

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(EditPersonModel model)
        {
            //returns the changed model; it should be the same
            return View(model);
        }
    }
}