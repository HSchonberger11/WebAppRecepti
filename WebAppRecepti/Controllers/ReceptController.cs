using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebAppRecepti.Models;

namespace WebAppRecepti.Controllers
{
    public class ReceptController : Controller
    {
        private readonly IRepozitorijUpita _repozitorijUpita;
        public ReceptController(IRepozitorijUpita repozitorijUpita)
        {
            _repozitorijUpita = repozitorijUpita;
        }

        public IActionResult Index()
        {
            return View(_repozitorijUpita.PopisRecept());
        }
        public IActionResult Create()
        {
            ViewData["KategorijaId"] = new SelectList(_repozitorijUpita.PopisKategorija(), "Id", "Naziv");
            int sljedeciId = _repozitorijUpita.SljedeciId();
            Recept recept = new Recept() { Id = sljedeciId };
            return View(recept);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Naziv,VrijemePripreme,BrojOsoba,Sastojci, Priprema, SlikaUrl, KategorijaId")] Recept recept)
        {
            ModelState.Remove("Kategorija"); //uklanjanje veze

            if (ModelState.IsValid)
            {
                _repozitorijUpita.Create(recept);
                return RedirectToAction("Index");   //ako je ve ok tu zavrsava metoda, ako je doslo do greske sljedeci dio se izvrsava

            }
            ViewData["KategorijaId"] = new SelectList(_repozitorijUpita.PopisKategorija(), "Id", "Naziv", recept.KategorijaId);
            return View(recept);

        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            Recept recept = _repozitorijUpita.DohvatiReceptSIdom(id);
            if (recept == null)
            {
                return NotFound();
            }
            ViewData["KategorijaId"] = new SelectList(_repozitorijUpita.PopisKategorija(), "Id", "Naziv", recept.KategorijaId);
            return View(recept);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id, [Bind("Id,Naziv,VrijemePripreme,BrojOsoba,Sastojci, Priprema,SlikaUrl, KategorijaId")] Recept recept)
        {
            if (id != recept.Id)
            {
                return NotFound();
            }
            ModelState.Remove("Kategorija");
            if (ModelState.IsValid)
            {
                _repozitorijUpita.Update(recept);
                return RedirectToAction("Index");
            }
            ViewData["KategorijaId"] = new SelectList(_repozitorijUpita.PopisKategorija(), "Id", "Naziv", recept.KategorijaId);
            return View(recept);



        }
        // GET: Dohvaća HTML stranicu sa receptom koje se odabralo obrisati
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = _repozitorijUpita.DohvatiReceptSIdom(Convert.ToInt32(id));
            if (film == null)
            {
                return NotFound();
            }
            return View(film);
        }

        // POST: Šalje Id vrijednost metodi u kontroleru koji se proslijeđuje iz Kontrolera repozitoriju u Modelu na brisanje
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var recept = _repozitorijUpita.DohvatiReceptSIdom(id);
            _repozitorijUpita.Delete(recept);
            return RedirectToAction("Index");
        }

        public ActionResult SearchIndex(string receptKategorija, string searchString)
        {
            var kategorija = new List<string>();

            var kategorijaUpit = _repozitorijUpita.PopisKategorija();

            ViewData["receptKategorija"] = new SelectList(_repozitorijUpita.PopisKategorija(), "Naziv", "Naziv", kategorijaUpit);

            var recepti = _repozitorijUpita.PopisRecept();

            if (!String.IsNullOrWhiteSpace(searchString))
            {
                recepti = recepti.Where(s => s.Naziv.Contains(searchString, StringComparison.OrdinalIgnoreCase)); // StringComparison.OrdinalIgnoreCase ignorira velika-mala slova 
            }

            if (string.IsNullOrWhiteSpace(receptKategorija))
                return View(recepti);
            else
            {
                return View(recepti.Where(x => x.Kategorija.Naziv == receptKategorija));
            }

        }


    }
}
