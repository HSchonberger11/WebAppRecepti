namespace WebAppRecepti.Models
{
    public interface IRepozitorijUpita
    {
        // za listu se moze koristiti i List <>, IList <> ali se u preko IEnumerable <> pokazao najbrzim
        IEnumerable<Recept> PopisRecept(); // R -read
        void Create(Recept recept);    //C - insert tj create
        void Delete(Recept recept);    // D - delete 
        void Update(Recept recept); //U -update
        int SljedeciId();
        int KategorijaSljedeciId();
        Recept DohvatiReceptSIdom(int id);
        IEnumerable<Kategorija> PopisKategorija();
        void Create(Kategorija kategorija);
        void Delete(Kategorija kategorija);
        void Update(Kategorija kategorija);
        Kategorija DohvatiKategorijuSIdom(int id);
        
    }
}
