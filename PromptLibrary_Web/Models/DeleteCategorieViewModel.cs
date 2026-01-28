using PromptLibrary_Modele;
using PromptLibrary_Modele.TableRef;

namespace PromptLibrary_Web.Models
{
    public class DeleteCategorieViewModel
    {
        public Categorie Categorie { get; set; } = null!;
        public List<Prompt> Prompts { get; set; } = new List<Prompt>();
    }
}
