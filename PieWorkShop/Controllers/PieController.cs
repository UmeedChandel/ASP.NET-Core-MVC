using Microsoft.AspNetCore.Mvc;
using PieWorkShop.Models;

namespace PieWorkShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository pieRepository;
        public PieController(IPieRepository pieRepository)
        {
            this.pieRepository = pieRepository;
        }

        public ViewResult List()
        {
            var pies = pieRepository.AllPies;
            return View(pies);
        }
    }
}
