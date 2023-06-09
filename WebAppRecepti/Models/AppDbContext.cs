using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace WebAppRecepti.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Recept> Recept { get; set; }
        public DbSet<Kategorija> Kategorija { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Kategorija>().HasData(
                new Kategorija() { Id = 1, Naziv = "Dorucak" },
                new Kategorija() { Id = 2, Naziv = "Rucak" },
                new Kategorija() { Id = 3, Naziv = "Vecera" },
                new Kategorija() { Id = 4, Naziv = "Desert" },
                new Kategorija() { Id = 5, Naziv = "Vegansko" });

            modelBuilder.Entity<Recept>().HasData(
                new Recept() { Id = 1, Naziv = "Energetski dorucak", VrijemePripreme = 5, BrojOsoba = 1, Sastojci = "35 g zobenih pahuljica, 2 zlice badema, 2 zlice suhog voća,150 ml biljnog napitka, 1 zlica namaza borovnica 100% iz voća,1 banana, 1 zlica svjezih borovnica, 1 zlicica cimeta", Priprema = "1. Zobenim pahuljicama dodajte bademe, suho voće, vocni namaz borovnica i prelijte toplim ili hladnim biljnim napitkom., 2.Promijesajte, dodajte narezanu bananu i borovnice.", SlikaUrl = "https://podravkaiovariations.blob.core.windows.net/a016b5a8-ae85-11ec-87f1-ae48ed498d44/v/f2b1f6a6-64bc-11eb-b6c2-0242ac130010/1600x1200-f2b21938-64bc-11eb-9498-0242ac130010.webp", KategorijaId = 1 },
                new Recept() { Id = 2, Naziv = "Tjestenina s lososom", VrijemePripreme = 15, BrojOsoba = 1, Sastojci = "300 g tjestenine, 200 g dimljenog lososa, cesnjak, maslac, kiselo vrhnje, vrhnje za kuhanje, sol, papar, vlasac, persin, limunov sok", Priprema = "1.Skuhati tjesteninu., 2.Na maslacu prziti cešsnjak i dodati kiselo vrhnje i vrhnje za kuhanje., 3.Dodati dimljeni losos, sol, papar i vlasac.", SlikaUrl = "https://www.sprinklesandsprouts.com/wp-content/uploads/2019/04/Creamy-Lemon-and-Salmon-Pasta-SQ.jpg", KategorijaId = 2 },
                new Recept() { Id = 3, Naziv = "Heljda i jagoda", VrijemePripreme = 5, BrojOsoba = 1, Sastojci = "50 g svijetle heljde, 200 g jagoda, 3-4 zlice chia sjemenki", Priprema = "1.Heljdu sirovu ili kratko kuhanu izmiksati i dodati jagode 2. Nekoliko zlica namocenih ( preko noci) chia sjemenki dodati na smjesu", SlikaUrl = "https://podravkaiovariations.blob.core.windows.net/4a9dff42-6402-11eb-8920-0242ac12002a/v/f2b1f6a6-64bc-11eb-b6c2-0242ac130010/1600x1200-f2b21938-64bc-11eb-9498-0242ac130010.webp", KategorijaId = 3 },
                new Recept() { Id = 4, Naziv = "Ice coffe tiramisu", VrijemePripreme = 15, BrojOsoba = 1, Sastojci = "200 ml mlijeka, 1 Dolcela HI protein Tiramisu shake, 1 banana, 70 ml crne kave, 1 kugla sladoleda od vanilije ili cokolade", Priprema = "1. Mlijeko, shake, bananu i kavu pomijesati u blenderu. 2.Izliti u visoku casu i posluzite uz kuglu sladoleda.", SlikaUrl = "https://podravkaiovariations.blob.core.windows.net/3b7f4dce-c30d-11ed-9cd1-c631db9ba15e/v/f2b1f6a6-64bc-11eb-b6c2-0242ac130010/1600x1200-f2b21938-64bc-11eb-9498-0242ac130010.webp", KategorijaId = 4 },
                new Recept() { Id = 5, Naziv = "Zeleni smoothie", VrijemePripreme = 10, BrojOsoba = 1, Sastojci = "1 salica zelenog povrća,1 zrela banana, 1 zlicica kikiriki maslaca,1 zlicica kokosovog ulja, 1 zlicice Vegeta Maestro kurkuma, 2 dcl vode ili jogurta, svjez djumbir", Priprema = "1. Povrce oprati i narezati na manje komade, bananu narezati, naribati korijen đumbira. 2.Povrce, bananu, djumbir, kurkumu, kikiriki maslac i jogurt ubaciti u blender te izmiksati.", SlikaUrl = "https://fraicheliving.com/wp-content/uploads/2021/01/fraiche-living-tropical-green-smoothie.jpg", KategorijaId = 5 }
                );
        }
    

    }
}
