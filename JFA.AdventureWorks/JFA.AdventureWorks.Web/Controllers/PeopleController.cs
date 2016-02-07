using JFA.AdventureWorks.Entities;
using JFA.AdventureWorks.Repository;
using JFA.AdventureWorks.Web.ViewModel;
using System.Web.Mvc;

namespace JFA.AdventureWorks.Web.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index(int? curPage, int? prevPage)
        {
            var db = new PersonRepository();
            int p, r;

            var model = new IndexPager<Person>();
            model.TheList = db.Search("", curPage ?? 1, Config.PageSize, out r, out p);
            model.CurrentPage = curPage ?? 1;
            model.PreviousPage = prevPage ?? 0;
            model.PageSize = Config.PageSize;
            model.TotalRecords = r;
           

            return View(model);
        }

        // GET: People/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: People/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: People/Create
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

        // GET: People/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: People/Edit/5
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

        // GET: People/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: People/Delete/5
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
