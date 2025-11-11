using Microsoft.AspNetCore.Mvc;
using Savedra.Web.Models;

namespace Savedra.Web.Controllers
{
    public class ClientController : Controller
    {
        private List<ClientModel> _clients;

        public ClientController()
        {
            _clients = GenerateClientsListMock();
        }

        public IActionResult Index()
        {
            Console.WriteLine(_clients.Count);

            return View(_clients);
        }

        public static List<ClientModel> GenerateClientsListMock()
        {
            var clients = new List<ClientModel>();

            for (int i = 1; i <= 5; i++)
            {
                var client = new ClientModel 
                {
                    Id = i,
                    FirstName = "Juan" + i,
                    LastName = "Santos" + i,
                    Email = "cliente" + i + "@gmail.com",
                    DateOfBirth = DateTime.Now.AddYears(-30),
                    RepresentativeId = i,
                    Representative = new RepresentativeModel 
                    {
                        Id = i,
                        FirstName = "Rodrigo " + i,
                        LastName = "Faro " + i,
                        CPF = "000.000.000-0" + i
                    }
                };

                clients.Add(client);
            }

            return clients;
        }
    }
}
