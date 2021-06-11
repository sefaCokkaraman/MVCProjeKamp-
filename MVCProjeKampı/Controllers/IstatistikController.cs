using DataAccesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProjeKampı.Controllers
{
    public class IstatistikController : Controller
    {
        // GET: Istatistik
        public ActionResult Index()
        {
            Context db = new Context();
            //Toplam Kategori Sayısı
            var s1 = db.Categories.Count();
            //
            //Başlık tablosunda "yazılım" kategorisine ait başlık sayısı
            var s2 = db.Headings.Where(x => x.Category.CategoryName == "yazılım").Count();
            //3) Yazar adında 'a' harfi geçen yazar sayısı
            var s3 = db.Writers.Where(x => x.WriterName.Contains("a")).ToList().Count();
            //4) En fazla başlığa sahip kategori adı
            var s4 = db.Categories.Where(x => x.CategoryID == db.Headings.GroupBy(a => a.CategoryID).OrderByDescending(a => a.Count()).Select(a => a.Key).FirstOrDefault()).Select(x => x.CategoryName).FirstOrDefault();

            // Kategori tablosunda durumu true olan kategoriler ile false olan kategoriler arasındaki sayısal fark
            var s5_1 = db.Categories.Where(x => x.CategoryStatus == true).Count();
            var s5_2 = db.Categories.Where(x => x.CategoryStatus == false).Count();

            ViewBag.S1 = s1;
            ViewBag.S2 = s2;
            ViewBag.S3 = s3;
            ViewBag.S4 = s4;


            if (s5_1<s5_2)
            {
                ViewBag.S5 = s5_2 - s5_1;

            }
            else
            {
                ViewBag.S5 = s5_1 - s5_2;

            }


            return View();
        }
    }
}