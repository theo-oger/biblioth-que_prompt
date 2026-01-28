using Microsoft.EntityFrameworkCore;
using PromptLibrary_DAL;
using PromptLibrary_Interfaces;
using PromptLibrary_Modele.TableRef;


namespace PromptLibrary_Services
{
    public class CategorieServices(PromptLibraryContext context) : ICategorieService
    {

        private readonly PromptLibraryContext ctx = context;

        public async Task<List<Categorie>> GetAllCategorieAsync()
        {
            return await ctx.Categories.ToListAsync();
        }

        public async Task<bool> CreateCategorieAsync(Categorie categorie)
        {
            context.Add(categorie);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateCategorieAsync(Categorie categorie)
        {
            Categorie? trackedsubcategorie = await context.Categories.FindAsync(categorie.Id);
            if (trackedsubcategorie is null)
                throw new DbUpdateConcurrencyException();

            context.Entry(trackedsubcategorie).CurrentValues.SetValues(categorie);
            return await context.SaveChangesAsync() > 0;
        }

        public bool IsCategorie(int id)
        {
            return context.Categories.Any(e => e.Id == id);
        }

        public async Task<Categorie?> GetById(int id)
        {
            return await ctx.Categories.SingleOrDefaultAsync(et => et.Id == id);
        }

        public async ValueTask<Categorie?> GetCategorieAsync(int id)
        {
            return await context.Categories.FindAsync(id);
        }

        public async Task<bool> DeleteCategorieAsync(Categorie categorie)
        {
            Categorie? trackedCategorie = await context.Categories.FindAsync(categorie.Id);
            if (null == trackedCategorie)
            {
                throw new DbUpdateConcurrencyException();
            }

            await context.Prompts.Where(fi => fi.Categorie == trackedCategorie).ForEachAsync(fi => fi.Categorie = null);
            context.Remove(trackedCategorie!);
            return await context.SaveChangesAsync() > 0;
        }

    }
}

