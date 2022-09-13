using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PrintMerchantsDetails.Models;

namespace PrintMerchantsDetails.Controllers
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
            MerchantTransactionDetails transactionDetails = new MerchantTransactionDetails()
            {
                MerchantName = "lIZPEE GLOBAL RESOURCES",
                Location = "NO. 74 NTA/MBUORA RD, PORTHARCOURT",
                TerminalId = 23011845,
                STAN = 003862,
                DateTime = DateTime.Parse("2022-08-30 17:32:58"),
                Amount = 0.01,
                AID = "A0000000041010",
                ExpiryDate = DateTime.Parse("11/24"),
                AuthorizationCode = "000000",
                DebitCard = "539941******3369",
                PTAD = "Global Accelerex",
                RRN = 000210002450,
                ResponseCode = 91

            };   
            
            return View(transactionDetails);
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
    }
}