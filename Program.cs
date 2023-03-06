using FirstMVCApp.DataContext;
using FirstMVCApp.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ProgrammingClubDataContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));

builder.Services.AddTransient<ProgrammingClubDataContext, ProgrammingClubDataContext>();
builder.Services.AddTransient<AnnouncementsRepository, AnnouncementsRepository>();
builder.Services.AddTransient<CodeSnippetsRepository, CodeSnippetsRepository>();
builder.Services.AddTransient<MembershipsRepository, MembershipsRepository>();
builder.Services.AddTransient<MembershipTypesRepository, MembershipTypesRepository>();
builder.Services.AddTransient<MembersRepository, MembersRepository>();
builder.Services.AddTransient<DonationsRepository, DonationsRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
