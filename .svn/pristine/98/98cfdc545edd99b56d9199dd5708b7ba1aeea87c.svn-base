using Microsoft.EntityFrameworkCore;
using PromptLibrary_Modele;
using PromptLibrary_Modele.TableRef;

namespace PromptLibrary_DAL
{
    public class PromptLibraryContext(DbContextOptions<PromptLibraryContext> options) : DbContext(options)
    {
        public DbSet<Prompt> Prompts { get; set; } = default!;
        public DbSet<Categorie> Categories { get; set; } = default!;
        public DbSet<SubCategorie> SubCategories { get; set; } = default!;
        public DbSet<Framework> Frameworks { get; set; } = default!;
    }
}
