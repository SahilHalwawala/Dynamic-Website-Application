using Microsoft.EntityFrameworkCore;
using StudentGradesApplication.Entities;
using StudentGradesApplication.Services;

namespace StudentGradesApplication
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews();
			

			var connectionString = builder.Configuration.GetConnectionString("GradesDb");
			builder.Services.AddDbContext<StudentGradesDbContext>(options => options.UseSqlServer(connectionString));

            builder.Services.AddScoped<IGradeService, GradeService>();

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
		}
	}
}
