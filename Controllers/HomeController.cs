using System.Diagnostics;
using ASPBuku.Models;
using Microsoft.AspNetCore.Mvc;


namespace ASPBuku.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Penerbit = "Ibnuesta";
            var infoterbit = new BukuModel()
            {
                Judul = "Belajar MVC" 
            };
            return View(infoterbit);
        }

        public IActionResult Privacy()
        {
            return View();
        }
       
        public IActionResult Judul()
        {
            var judulbuku = new BukuModel()
            {
                Judul = "Belajar ASP.NET"
            };
            return View(judulbuku);
        }

        public IActionResult Halo()
        {
            var pesan = "Halo Dunia";
            return new ContentResult
            {
                Content = pesan,
                ContentType = "text/html"
            };
        }
        public IActionResult DataJson()
        {
            var data = new
            {
                nama = "Muhamad Ibnu",
                buku = "Ternak Lele"
            };
            return new JsonResult(data);
        }
        public IActionResult DownloadBuku()
        {
            var filepath = "D:\\belajarAspnet\\ASPBuku\\wwwroot\\SuratPengalamanKerja.pdf";
            return new PhysicalFileResult(filepath, "application/pdf");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
