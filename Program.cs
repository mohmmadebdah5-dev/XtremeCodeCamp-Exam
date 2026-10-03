using Microsoft.EntityFrameworkCore;
using XtremeCodeCampExam.Data;
using XtremeCodeCampExam.Services;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ExamDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection") ?? "Data Source=exam.db"));
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(o => { o.IdleTimeout=TimeSpan.FromHours(4); o.Cookie.HttpOnly=true; o.Cookie.IsEssential=true; });
var app=builder.Build();
using(var scope=app.Services.CreateScope()){var db=scope.ServiceProvider.GetRequiredService<ExamDbContext>(); db.Database.EnsureCreated(); if(!db.Questions.Any()){db.Questions.AddRange(ExamBank.DefaultQuestions()); db.SaveChanges();}}
app.UseStaticFiles(); app.UseRouting(); app.UseSession();
app.MapControllerRoute(name:"default", pattern:"{controller=Exam}/{action=Index}/{id?}");
app.Run();
