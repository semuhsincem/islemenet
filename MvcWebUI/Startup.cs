using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using BusinessLayer.Abstract.Middle;
using BusinessLayer.Concrete;
using BusinessLayer.Concrete.Middle;
using DataAccessLayer.Abstract;
using DataAccessLayer.Abstract.Middle;
using DataAccessLayer.Concrete.EntityFramework;
using DataAccessLayer.Concrete.EntityFramework.Context;
using DataAccessLayer.Concrete.EntityFramework.Middle;
using Helper.Constants;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using MvcWebUI.IdentityCore;

namespace MvcWebUI
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
            services.AddDbContext<AppDbContext>(_ => _.UseSqlServer("Server=.;Database=CNC;Trusted_Connection=True;"));
            services.AddIdentity<AppUser, AppRole>(opt=>
            {
                opt.Password.RequireDigit = false;
                opt.Password.RequireLowercase= false;
                opt.Password.RequiredLength = 6;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequiredUniqueChars = 0;
            })
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

            services.AddScoped<IRFQService, RFQManager>();
            services.AddScoped<IConstantService, ConstantManager>();
            services.AddScoped<IRFQDal, EfRFQDal>();
            services.AddScoped<ICertificationDal, EfCertificationDal>();
            services.AddScoped<ICompanySizeDal, EfCompanySizeDal>();
            services.AddScoped<ICountryDal, EfCountryDal>();
            services.AddScoped<IIllerDal, EfIllerDal>();
            services.AddScoped<IIndustryDal, EfIndustryDal>();
            services.AddScoped<IMaterialDal, EfMaterialDal>();
            services.AddScoped<ITechnologyDal, EfTechnologyDal>();

            services.AddScoped<IUserCertificateService, UserCertificateManager>();
            services.AddScoped<IUserCertificationDal, EfUserCertificationDal>();

            services.AddScoped<IUserIndustryService, UserIndustryManager>();
            services.AddScoped<IUserIndustryDal, EfUserIndustryDal>();

            services.AddScoped<IUserMaterialService, UserMaterialManager>();
            services.AddScoped<IUserMaterialDal, EfUserMaterialDal>();

            services.AddScoped<IUserTechnologyService, UserTechnologyManager>();
            services.AddScoped<IUserTechnologyDal, EfUserTechnologyDal>();


            services.AddScoped<IRFQCountryService, RFQCountryManager>();
            services.AddScoped<IRFQCountryDal, EfRFQCountryDal>();

            services.AddScoped<IRfqFileService, RfqFileManager>();
            services.AddScoped<IRfqFileDal, EfRfqFileDal>();

            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            #region validations
            //services.AddTransient<IValidator, RegisterViewModelValidator>();

            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            var cultureInfo = new CultureInfo("tr-TR");
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=AnaSayfa}/{action=Index}/{id?}");
            });
        }
    }
}
