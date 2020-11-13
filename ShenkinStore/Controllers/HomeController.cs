using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShenkinStore.Models;
using ShenkinStore.ViewModels;

namespace ShenkinStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult ProductsLabels()
        {
            KmeansAlgo kmeans = new KmeansAlgo();
            KmeansViewModel viewModel = new KmeansViewModel
            {
                labels = kmeans.k_means2(),
                topproducts = kmeans.distans()
            };
            return View(viewModel);
        }

        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult ProductsLabels()
        //{
        //    KmeansAlgo kmeans = new KmeansAlgo();
        //    var viewModel = new KmeansViewModel
        //    {
        //        labels = kmeans.k_means2(),
        //        topproducts=kmeans.distans()
        //    };
         
        //    return View(viewModel);
        //}
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public ActionResult Shop()
        {
            ViewBag.Message = "Your product shop page.";

            return View();
        }

    }
}
