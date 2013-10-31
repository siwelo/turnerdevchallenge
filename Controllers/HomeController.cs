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
            return View(_db.Titles.ToList());
        }

        public ActionResult TitleSearch(FormCollection formVal)
        {
            //IQueryable<Models.Title> titleQuery = _db.Titles.Where(exp => exp.TitleName.Contains(formVal["titleSearch"]));

              //var titleQuer = _db.Titles.Where("TitleName LIKE @titleSearch", new ObjectParameter("titleSearch", formVal["titleSearch"]));
              //var title = from t in _db.Titles where t.TitleName.Contains(formVal["titleSearch"])
                            //select t;
            string titleSearch = formVal["titleSearch"];
            var titleList = from titles in _db.Titles where titles.TitleName.Contains(titleSearch) select titles;
            //var resultList = titleList.ToList();
            return View(titleList.ToList());
        }

        //
        // GET: /Home/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Home/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Home/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Home/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Home/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
