using Microsoft.AspNetCore.Mvc;

namespace BG_Dancers_and_Schools.Controllers
{
    public class ProtocolController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            var NewProtocolVM = new ProtocolViewModel();
            return View(NewProtocolVM);
        }
        [HttpPost]
        public IActionResult Create(ProtocolViewModel protocolVM)
        {
            var NewProtocol = new ProtocolViewModel();
            NewProtocol.Name = 
        }
    }
}
