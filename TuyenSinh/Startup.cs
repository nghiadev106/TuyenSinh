using TuyenSinh.Model;
using TuyenSinh.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using TuyenSinh.IdentityModel;

namespace TuyenSinh
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<tuyensinhContext>(options =>
              options.UseSqlServer(
                  Configuration.GetConnectionString("DefaultConnection")));

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            //services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            //   .AddCookie(options =>
            //   {
            //       options.LoginPath = "/Admin/User/Login";
            //       options.AccessDeniedPath = "/User/Forbidden/";
            //   });

            services.AddTransient<IStorageService, FileStorageService>();
            services.AddTransient<ICategoryService,CategoryService>();
            services.AddTransient<INewsService, NewsService>();
            services.AddTransient<ICategoryNewsService, CategoryNewsService>();
            services.AddTransient<IQuestionService, QuestionService>();
            services.AddTransient<IStudentService, StudentService>();
            services.AddTransient<IMajorService, MajorService>();


            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(100);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            services.AddControllersWithViews();
            IMvcBuilder builder = services.AddRazorPages();
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

#if DEBUG
            if (environment == Environments.Development)
            {
                builder.AddRazorRuntimeCompilation();
            }
#endif
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseRouting();     
            
            app.UseAuthorization();

            app.UseSession();
          

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                name: "admin",
                pattern: "admin", new
                {
                    area = "Admin",
                    controller = "User",
                    action = "Login"
                });

                endpoints.MapControllerRoute(
                name: "areas",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );

                endpoints.MapControllerRoute(
               name: "question",
               pattern: "cau-hoi", new
               {
                   controller = "Question",
                   action = "Index"
               });

                endpoints.MapControllerRoute(
              name: "question",
              pattern: "dat-cau-hoi", new
              {
                  controller = "Question",
                  action = "DatCauHoi"
              });

                endpoints.MapControllerRoute(
                name: "question detail",
                pattern: "cau-hoi/chi-tiet/{url}/{id}", new
                {
                    controller = "Question",
                    action = "Detail"
                });

                endpoints.MapControllerRoute(
                name: "Blog",
                pattern: "tin-tuc", new
                {
                    controller = "Blogs",
                    action = "ListBlogs"
                });

                endpoints.MapControllerRoute(
                name: "Blog Detail",
                pattern: "chi-tiet-tin/{url}/{id}", new
                {
                    controller = "Blogs",
                    action = "DetailBlog"
                });

                endpoints.MapControllerRoute(
               name: "Blog by category",
               pattern: "tin-tuc/{url}/{id}", new
               {
                   controller = "Blogs",
                   action = "ListBlogCategories"
               });

            

                endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");


                endpoints.MapRazorPages();
            });
        }
    }
}
