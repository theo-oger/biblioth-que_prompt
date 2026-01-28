using PromptLibrary_Modele.TableRef;


namespace PromptLibrary_Interfaces
{
    public interface ISubCategorieService
    {
        Task<List<SubCategorie>> GetAllSubCategorieAsync();
        Task<bool> UpdateSubCategorieAsync(SubCategorie subcategorie);
        bool IsSubCategorie(int id);
        Task<SubCategorie?> GetById(int id);
        ValueTask<SubCategorie?> GetSubCategorieAsync(int id);
        Task<bool> DeleteSubCategorieAsync(SubCategorie subcategorie);
        Task<bool> CreateSubCategorieAsync(SubCategorie subcategorie);
    }
}
