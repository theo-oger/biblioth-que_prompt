using Microsoft.EntityFrameworkCore;
using PromptLibrary_DAL;
using PromptLibrary_Interfaces;
using PromptLibrary_Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
// Connexion à la base de données
builder.Services.AddDbContext<PromptLibraryContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PromptLibraryConnexion") ?? throw new InvalidOperationException("Chaîne de connexion 'PromptLibraryConnexion' non trouvée.")));
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IPromptServices, PromptServices>();
builder.Services.AddScoped<IFrameworkService, FrameworkServices>();
builder.Services.AddScoped<ICategorieService, CategorieServices>();
builder.Services.AddScoped<ISubCategorieService, CategorieSubServices>();

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    SeedData.Initialize(services);
}
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Catalogue}/{action=Index}/{id?}");

app.Run();
