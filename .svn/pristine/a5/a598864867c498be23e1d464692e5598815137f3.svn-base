using Microsoft.EntityFrameworkCore;
using PromptLibrary_DAL;
using PromptLibrary_Interfaces;
using PromptLibrary_Modele.TableRef;


namespace PromptLibrary_Services
{
    public class FrameworkServices(PromptLibraryContext context) : IFrameworkService

    {
        private readonly PromptLibraryContext ctx = context;

        public async Task<List<Framework>> GetAllFrameworkAsync()
        {
            return await ctx.Frameworks.ToListAsync();
        }

        public async Task<bool> CreateFrameworkAsync(Framework framework)
        {
            context.Add(framework);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<Framework?> GetById(int id)
        {
            return await ctx.Frameworks.SingleOrDefaultAsync(et => et.Id == id);
        }

        public async Task<bool> DeleteFrameworkAsync(Framework framework)
        {
            Framework? trackedFramework = await context.Frameworks.FindAsync(framework.Id);
            if (null == trackedFramework)
            {
                throw new DbUpdateConcurrencyException();
            }

            await context.Prompts.Where(fi => fi.Framework == trackedFramework).ForEachAsync(fi => fi.Framework = null);
            context.Remove(trackedFramework!);
            return await context.SaveChangesAsync() > 0;
        }

        public async ValueTask<Framework?> GetFrameworkAsync(int id)
        {
            return await context.Frameworks.FindAsync(id);
        }

        public async Task<bool> UpdateFrameworkAsync(Framework framework)
        {
            Framework? trackedframework = await ctx.Frameworks.FindAsync(framework.Id);
            if (trackedframework is null)
                throw new DbUpdateConcurrencyException();

            ctx.Entry(trackedframework).CurrentValues.SetValues(framework);
            return await ctx.SaveChangesAsync() > 0;
        }

        public bool IsFramework(int id)
        {
            return ctx.Frameworks.Any(e => e.Id == id);
        }
    }
}
