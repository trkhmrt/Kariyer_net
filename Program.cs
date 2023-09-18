using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization; //Authorizefilter için eklenmesi gerekli

namespace Kariyer_net;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        


        
        //Authorizon işlemi için eklendi
        //builder.Services.AddMvc(config =>
        //{
        //    //Proje düzeyinde authorizan işlemi oluşturduk ve bu sayede bütün sitelere şu anda erişim engelli.İzin verdiğimiz sayfalara sadece erişim verilir.
        //    var kural = new AuthorizationPolicyBuilder()
        //    .RequireAuthenticatedUser()
        //    .Build();
        //    config.Filters.Add(new AuthorizeFilter(kural));
        //});

        //===================================================================
        //Authontice olmadan girilen sayfalardaki hataları göstermeden ilgili sayfaya yönlendirmesi için kullandık bu komutu.
        //builder.Services.AddMvc();
       //builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>
       // {
       //     x.LoginPath = "/Login/Index";
       // });

        var app = builder.Build();

        //Otantike olmayı kullanabilmek için bunu kullanmamız gerekiyor
        //app.UseAuthentication();


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



        //app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}
