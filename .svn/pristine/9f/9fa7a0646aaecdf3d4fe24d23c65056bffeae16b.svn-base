
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace PromptLibrary_Web.Models
{
    public class CreateCardViewModel
    {

        public int Id { get; set; }

        [Display(Name = "Titre")]
        [Required(ErrorMessage = "Le titre est obligatoire.")]
        [StringLength(200, ErrorMessage = "Le titre ne doit pas dépasser {1} caractères.")]
        public string Titre { get; set; } = string.Empty;

        [Display(Name = "Catégorie")]
        [Required(ErrorMessage = "Veuillez sélectionner une catégorie.")]
        public int? CategorieId { get; set; }

        [Display(Name = "Sous-catégorie")]
        [Required(ErrorMessage = "Veuillez sélectionner une catégorie.")]

        public int? SubCategorieId { get; set; }

        [Display(Name = "Framework")]
        [Required(ErrorMessage = "Veuillez sélectionner une catégorie.")]

        public int? FrameworkId { get; set; }

        [Display(Name = "Contenu")]
        [Required(ErrorMessage = "Le contenu est obligatoire.")]
        public string? Content { get; set; }

        [Display(Name = "Actif ?")]
        public bool? IsActive { get; set; } = true;

        public SelectList? LesFrameworks { get; set; }
        public SelectList? LesSubCategories { get; set; }
        public SelectList? LesCategories { get; set; }
    }
}
