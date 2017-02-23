using System.Collections.Generic;
using SimpleHttpServer.Models;
using SimpleMVC.App.BindingModels;
using SimpleMVC.App.Data;
using SimpleMVC.App.Models;
using SimpleMVC.App.MVC.Attributes.Methods;
using SimpleMVC.App.MVC.Controllers;
using SimpleMVC.App.MVC.Interfaces;
using SimpleMVC.App.MVC.Interfaces.Generic;
using SimpleMVC.App.Services;
using SimpleMVC.App.ViewModels;

namespace SimpleMVC.App.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult About()
        {
            return View();
        }
        [HttpGet]
        public IActionResult<IEnumerable<ProductViewModel>>  Products()
        {
            KniveService service = new KniveService(Data.Data.Contex);
            var viewModel = service.GetProducts();
            return this.View(viewModel);
        }
       

        [HttpGet]
        public IActionResult Contacts()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contacts(MeesageBindingModel message)
        {
            if (string.IsNullOrEmpty(message.Sender) || string.IsNullOrEmpty(message.Subject))
            {
                this.Redirect(new HttpResponse() , "/home/contacts");
                
            }
            var service = new MessageService();

            service.AddMessageToBase(message);
            
            return View("Home","Index");
        }
    }
}
