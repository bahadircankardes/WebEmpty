using Microsoft.AspNetCore.Mvc;



public class HomeController : Controller
{
    List<PersonelVM> personeller = new List<PersonelVM>();
    public HomeController()
    {
        
    }
    public IActionResult Index()
    {
        PersonelVM p1 = new PersonelVM() {
            Id = 1,
            Ad = "Ali",
            Soyad = "Yilmaz",
            Email = "ali@gmail.com",
            TcNo = "40423685248"
        };

        PersonelVM p2 = new PersonelVM() {
            Id = 2,
            Ad = "Veli",
            Soyad = "Yilmaz",
            Email = "veli@gmail.com",
            TcNo = "40423685247"
        };

        PersonelVM p3 = new PersonelVM() {
            Id = 3,
            Ad = "Ayşe",
            Soyad = "Yilmaz",
            Email = "ayse@gmail.com",
            TcNo = "40423685246"
        };

        PersonelVM p4 = new PersonelVM() {
            Id = 4,
            Ad = "Fatma",
            Soyad = "Yilmaz",
            Email = "fatma@gmail.com",
            TcNo = "40423685245"

        };
        personeller.Add(p1);
        personeller.Add(p2);
        personeller.Add(p3);
        personeller.Add(p4);
        return View(personeller); //personeller listesinin html ini çıkartması için view e gönderiyoruz.
    }
}