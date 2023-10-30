using System.ComponentModel.DataAnnotations;

namespace BoutiqueDITI5.Model
{
    public class Article
    {
        [Key]
        public int IdArticle { get; set; }
        [Required]
        public int CodeArticle { get; set; }
        public string Description { get; set; } 
        public int Quantite { get; set; }

        public double PrixUnit { get;set; }

        public DateTime DatePeremption { get; set; }

    }
}
