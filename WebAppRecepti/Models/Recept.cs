using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebAppRecepti.Models
{
    public class Recept
    {

        [Required(ErrorMessage = "Polje {0} je obvezno.")]
        [Display(Name = "#")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // s ovim neće polje napraviti AUTO_INCREMENT
        public int Id { get; set; } // get dohvati nešto iz Id-a, a set dohvati nešto iz Id-a
        [Required(ErrorMessage = "Polje {0} je obvezno.")]
        public string Naziv { get; set; }
        [Required(ErrorMessage = "Polje {0} je obvezno.")]
        [Display(Name = "Vrijeme pripreme")]
        public int VrijemePripreme { get; set; }
        [Required(ErrorMessage = "Polje {0} je obvezno.")]
        [Display(Name = "Broj osoba")]
        public int BrojOsoba { get; set; }
        [Required(ErrorMessage = "Polje {0} je obvezno.")]


        public string Sastojci { get; set; }
        [Required(ErrorMessage = "Polje {0} je obvezno.")]
        public string Priprema { get; set; }



        [Required(ErrorMessage = "Polje {0} je obvezno.")]
        [Display(Name = "Poster")]
        public string SlikaUrl { get; set; }
        [Display(Name = "Kategorija")]
        public int KategorijaId { get; set; }

        public Kategorija Kategorija
        {
            get; set;
        }
    }
}
