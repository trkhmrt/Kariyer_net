using Kariyer_net.Concrete;
using Kariyer_net.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization; //Authorizefilter için eklenmesi gerekli

namespace Kariyer_net;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddDbContext<Context>();
        builder.Services.AddControllersWithViews();

        builder.Services.AddIdentity<Kullanici, IdentityRole>()
    .AddEntityFrameworkStores<Context>()
    .AddDefaultTokenProviders();

        builder.Services.Configure<IdentityOptions>(options =>
        {
            //password

            options.Password.RequireNonAlphanumeric = true;
            options.Password.RequiredLength = 6;
            options.Password.RequireDigit = true;
            options.Password.RequireLowercase = true;
            options.Password.RequireUppercase = true;


            options.Lockout.MaxFailedAccessAttempts = 5;
            options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
            options.Lockout.AllowedForNewUsers = true;


            options.User.RequireUniqueEmail = true;

            options.SignIn.RequireConfirmedPhoneNumber = false;
            options.SignIn.RequireConfirmedEmail = true;
            

        });

        //Authorizon işlemi için eklendi
        builder.Services.AddMvc(config =>
        {
            //Proje düzeyinde authorizan işlemi oluşturduk ve bu sayede bütün sitelere şu anda erişim engelli.İzin verdiğimiz sayfalara sadece erişim verilir.
            var kural = new AuthorizationPolicyBuilder()
            .RequireAuthenticatedUser()
            .Build();
           config.Filters.Add(new AuthorizeFilter(kural));
        });

        //===================================================================
        //Authontice olmadan girilen sayfalardaki hataları göstermeden ilgili sayfaya yönlendirmesi için kullandık bu komutu.
        builder.Services.AddMvc();
                builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>
        {
            x.LoginPath = "/Account/Login";
            x.LogoutPath = "/Home/Index";
        });
       



        var app = builder.Build();

       


        //Otantike olmayı kullanabilmek için bunu kullanmamız gerekiyor
        app.UseAuthentication();


        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }


        //Sessionı kullanmak için
        


        app.UseHttpsRedirection();
        app.UseStaticFiles();

        //Hata Sayfası yönetimi
        app.UseStatusCodePagesWithReExecute("/ErrorPage/Index", "?code={0}");

      
        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}"); 
            

        app.Run();
    }
}
