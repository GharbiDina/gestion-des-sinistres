using AM.ApplicationCore.Interfaces;
using ApplicationCore.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WEB.UI.Controllers
{
    public class ExpertisesController : Controller
    {
        readonly IService<Expertise> serviceExpertise;
        public ExpertisesController (IService<Expertise> serviceExpertise)
        {
            this.serviceExpertise = serviceExpertise;
        }

        // GET: ExpertisesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ExpertisesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ExpertisesController/Create
        public ActionResult Create()
        {


            return View();

        }

        // POST: ExpertisesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Expertise dina)
        {
            try
            {
                serviceExpertise.Add(dina);
                serviceExpertise.Commit();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ExpertisesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ExpertisesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ExpertisesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ExpertisesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
