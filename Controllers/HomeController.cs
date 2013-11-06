using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using turnerdevchallenge.Models;
using System.Data.Objects;
using System.Data;

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
        // GET: /Home/Details

        public ActionResult Details(int id)
        {
            Title thisTitle = _db.Titles.Where(title => title.TitleId == id).SingleOrDefault();
            var participants = from c in _db.Participants
                        join cm in _db.TitleParticipants on c.Id equals cm.ParticipantId
                        where (cm.TitleId == id && cm.RoleType == "Actor")
                        select c;

            TitleDetailViewModel tdvm = new TitleDetailViewModel();
            tdvm.thisTitle = thisTitle;
            tdvm.storylines = thisTitle.StoryLines.ToList();
            tdvm.participants = participants.ToList();
            return View(tdvm);
        }

    }
}
