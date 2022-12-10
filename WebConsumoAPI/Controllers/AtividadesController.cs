using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebConsumoAPI.Interfaces;

namespace WebConsumoAPI.Controllers
{
    public class AtividadesController : Controller
    {
        private readonly IAtividade _IAtividade;
        public AtividadesController(IAtividade IAtividade)
        {
            _IAtividade = IAtividade;
        }

        // GET: AtividadesController
        public ActionResult Index()
        {
            return View(_IAtividade.List());
        }

        // GET: AtividadesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AtividadesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AtividadesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: AtividadesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AtividadesController/Edit/5
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

        // GET: AtividadesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AtividadesController/Delete/5
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
