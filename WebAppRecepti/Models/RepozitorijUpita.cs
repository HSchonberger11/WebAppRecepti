using Microsoft.EntityFrameworkCore;

namespace WebAppRecepti.Models
{
    public class RepozitorijUpita : IRepozitorijUpita
    {
        private readonly AppDbContext _appDbContext;
        public RepozitorijUpita(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void Create(Recept recept)
        {
            _appDbContext.Add(recept);
            _appDbContext.SaveChanges();
        }

        public void Create(Kategorija kategorija)
        {
            _appDbContext.Add(kategorija);
            _appDbContext.SaveChanges();
        }

        public void Delete(Recept recept)
        {
            _appDbContext.Recept.Remove(recept);
            _appDbContext.SaveChanges();
        }

        public void Delete(Kategorija kategorija)
        {
            _appDbContext.Kategorija.Remove(kategorija);
            _appDbContext.SaveChanges();
        }

        public Kategorija DohvatiKategorijuSIdom(int id)
        {
            return _appDbContext.Kategorija.Find(id);
        }

        public Recept DohvatiReceptSIdom(int id)
        {
            return _appDbContext.Recept.Include(k => k.Kategorija).FirstOrDefault(f => f.Id == id);
        }

        public IEnumerable<Kategorija> PopisKategorija()
        {
            return _appDbContext.Kategorija;
        }
        public int KategorijaSljedeciId()
        {
            int zadnjiId = _appDbContext.Kategorija
               .Count();

            int sljedeciId = zadnjiId + 1;
            return sljedeciId;
        }
        public IEnumerable<Recept> PopisRecept()
        {
            return _appDbContext.Recept.Include(k => k.Kategorija);
        }

        public int SljedeciId()
        {
            int zadnjiId = _appDbContext.Recept.Include(k => k.Kategorija).Max(x => x.Id);
            int sljedeciId = zadnjiId + 1;
            return sljedeciId;
        }

        public void Update(Recept recept)
        {
            _appDbContext.Recept.Update(recept);
            _appDbContext.SaveChanges();
        }

        public void Update(Kategorija kategorija)
        {
            _appDbContext.Kategorija.Update(kategorija);
            _appDbContext.SaveChanges();
        }
    }
}
