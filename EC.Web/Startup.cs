using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EC.Web.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity.UI.Services;
using EC.Web.Services;
using EC.Web.Common.Extensions;
using EC.Web.Helpers;
using AutoMapper;
using Microsoft.Extensions.FileProviders;
using System.IO;
using EC.Web.Areas.Inventory.Data.B1;
using System.Runtime.Loader;
using System;
using System.Reflection;
using DinkToPdf.Contracts;
using EC.Web.Services.Template;
using DinkToPdf;
using EC.Web.Services.RMA;
using EC.Web.Services.File;
using EC.Web.Services.Examples;
using EC.Web.Areas.Examples.Data.Entity;
using EC.Web.Services.Identity;
using EC.Web.Areas.Shared.Services;

namespace EC.Web
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<B1DbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("B1Connection")));

            services.AddIdentity<ApplicationUser, ApplicationRole>(options => options.Stores.MaxLengthForKeys = 128)
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultUI()
                .AddDefaultTokenProviders();

            services.AddDbContext<ExampleDbContext>(options =>
            {
                options.UseSqlServer(
                    Configuration.GetConnectionString("ExampleConnection"));
            });

            services.AddDistributedMemoryCache();

            services.AddSession();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddRazorPagesOptions(options =>
            {
                options.AllowAreas = true;
                options.Conventions.AuthorizeAreaFolder("Identity", "/Account/Manage");
                options.Conventions.AuthorizeAreaPage("Identity", "/Account/Logout");
                options.Conventions.AuthorizeAreaFolder("Admin", "/ApplicationUsers", new[] { "admin" });
                options.Conventions.AuthorizeAreaFolder("Admin", "/ApplicationRoles", new[] { "admin" });
                options.Conventions.AuthorizeAreaFolder("Admin", "/ApplicationMenus", new[] { "admin" });
                options.Conventions.AuthorizeAreaFolder("Inventory", "/DailyInventory", new[] { "admin", "user" });
                options.Conventions.AuthorizeAreaFolder("RMA", "/RMARequests", new[] { "admin", "user" });
            })
            .AddSessionStateTempDataProvider();

            services.AddAntiforgery(o => o.HeaderName = "XSRF-TOKEN");

            services.AddHttpContextAccessor();

            services.AddAutoMapper(x => x.AddProfile(new MappingEntity()));

            services.AddTransient<IApplicationMenuService, ApplicationMenuService>();

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = $"/Identity/Account/Login";
                options.LogoutPath = $"/Identity/Account/Logout";
                options.AccessDeniedPath = $"/Identity/Account/AccessDeined";
            });

            var loadContext = new CustomAssemblyLoadContext();
            loadContext.LoadUnmanagedLibrary(Path.Combine(Directory.GetCurrentDirectory(), "libwkhtmltox.dll"));

            // Add converter to DI
            services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));

            services.AddTransient<ITemplateService, TemplateService>();

            services.AddSingleton<IUploadFileService, UploadFileService>();

            services.AddSingleton<IExamplesRepository, ExamplesRepository>();

            services.AddSingleton<IEmailSender, EmailSender>();

            services.AddTransient<IUserService, UserService>();

            services.AddTransient<IB1UserService, B1UserService>();

            services.AddTransient<IB1CardService, B1CardService>();

            services.AddTransient<IB1ProductService, B1ProductService>();

            services.Configure<AuthMessageSenderOptions>(Configuration);

            services.AddTransient<IProductService, ProductService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app,
            IHostingEnvironment env,
            ApplicationDbContext context,
            RoleManager<ApplicationRole> roleManager,
            UserManager<ApplicationUser> userManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            if (env.IsDevelopment())
            {
                app.UseStaticFiles(new StaticFileOptions()
                {
                    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"node_modules")),
                    RequestPath = new PathString("/node_modules")

                });
            }

            app.UseAuthentication();

            app.UseSession();

            app.UseMvc();

            app.UseCookiePolicy();
            // initial DataSeed
            DataSeed.Initialize(context, userManager, roleManager).Wait();
        }

        internal class CustomAssemblyLoadContext : AssemblyLoadContext
        {
            public IntPtr LoadUnmanagedLibrary(string absolutePath)
            {
                return LoadUnmanagedDll(absolutePath);
            }

            protected override IntPtr LoadUnmanagedDll(String unmanagedDllName)
            {
                return LoadUnmanagedDllFromPath(unmanagedDllName);
            }

            protected override Assembly Load(AssemblyName assemblyName)
            {
                throw new NotImplementedException();
            }
        }
    }
}
