using PromptLibrary_Modele.TableRef;

namespace PromptLibrary_Web.Models
{
    public class AdministrationViewModel

    {
        public List<Categorie> Categories { get; set; } = new();
        public List<Framework> Frameworks { get; set; } = new();
        public List<SubCategorie> SubCategories { get; set; } = new();
        public List<PromptLibrary_Modele.Prompt> Prompts { get; set; } = new();
    }
}


