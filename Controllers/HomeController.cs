using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using turnerdevchallenge.Models;
using System.Data.Objects;

namespace turnerdevchallenge.Controllers
{
    public class HomeController : Controller
    {

        private TitlesEntities1 _db = new TitlesEntities1(); 

        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TitleSearch(FormCollection formVal)
        {
            string titleSearch = formVal["titleSearch"];
            var titleList = from titles in _db.Titles where titles.TitleName.Contains(titleSearch) select titles;

            return View(titleList.ToList());
        }

        //
        // GET: /Home/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

    }
}
