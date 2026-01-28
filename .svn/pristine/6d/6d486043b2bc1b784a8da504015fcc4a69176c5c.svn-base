using PromptLibrary_Modele.TableRef;

namespace PromptLibrary_Interfaces
{
    public interface IFrameworkService
    {
        Task<List<Framework>> GetAllFrameworkAsync();
        Task<bool> CreateFrameworkAsync(Framework framework);
        Task<Framework?> GetById(int id);
        Task<bool> UpdateFrameworkAsync(Framework framework);
        bool IsFramework(int id);
        Task<bool> DeleteFrameworkAsync(Framework framework);
        ValueTask<Framework?> GetFrameworkAsync(int id);
    }
}
