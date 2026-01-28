using PromptLibrary_Modele.TableRef;

namespace PromptLibrary_Interfaces
{
    public interface ICategorieService
    {
        Task<List<Categorie>> GetAllCategorieAsync();
        Task<bool> CreateCategorieAsync(Categorie categorie);
        Task<Categorie?> GetById(int id);
        Task<bool> UpdateCategorieAsync(Categorie categorie);
        bool IsCategorie(int id);
        Task<bool> DeleteCategorieAsync(Categorie categorie);
        ValueTask<Categorie?> GetCategorieAsync(int id);
    }
}
