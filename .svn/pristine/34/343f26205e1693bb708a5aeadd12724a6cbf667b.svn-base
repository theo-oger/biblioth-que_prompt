using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PromptLibrary_Modele.TableRef
{
    [Table("Framework")]
    public class Framework
    {
        public int Id { get; set; }

        [Display(Name = "Nom")]
        [StringLength(100)]
        [Required(ErrorMessage = "Le nom est obligatoire.")]
        public string Nom { get; set; } = null!;

        [Display(Name = "Description")]
        public string? Description { get; set; }

        [Display(Name = "Contenu")]
        public string? Contenu { get; set; }

        [Display(Name = "Est actif ?")]
        public bool? IsActive { get; set; }

    }
}
