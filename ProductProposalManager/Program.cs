using ProductProposalManager.Repositories.Implementation;
using ProductProposalManager.Repositories.Interface;
using ProductProposalManager.Services.Implementation;
using ProductProposalManager.Services.Interface;
using ProductProposalManager.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddControllers();

builder.Services.AddSingleton<IUserRepository, UserRepository>();
builder.Services.AddSingleton<IUserService, UserService>();
builder.Services.AddSingleton<IProposalRepository, ProposalRepository>();
builder.Services.AddSingleton<IProposalService, ProposalService>();
builder.Services.AddSingleton<IProductRepository, ProductRepository>();
builder.Services.AddSingleton<IProductService, ProductService>();
builder.Services.AddSingleton<AuthenticationService>();


builder.Services.AddHttpClient("api", client =>
{
    client.BaseAddress = new Uri("http://localhost:5229/");
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
