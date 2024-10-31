namespace WebGiris
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();// Bu servisleri eklerseniz eğer MVC projesi olur 
            //builder.Services.AddRazorPages();// Razor web application olur.
            var app = builder.Build();
            app.UseStaticFiles(); // wwwroot klasörünü kullanıma açar

                //Domainden sonraki ilk kısım kontroller kısmıdır.
                //ikinci kısım "/" işareti ile birbirinden ayrilir.
                //Buras ı da bu konroller içinde hangi metoda gideceğini belirler
                //En son id değeeri vardir ama zorunlu değildir. ? ile nullable verilmiştir.
            app.MapControllerRoute(
                name: "default", 
                pattern: "{controller=Home}/{action=Index}/{id?}");
                
            app.Run();
        }
    }
}




