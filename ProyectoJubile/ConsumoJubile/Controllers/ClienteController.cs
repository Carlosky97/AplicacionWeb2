using ConsumoJubile.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace ConsumoJubile.Controllers
{
    public class ClienteController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:44381/api");
        private readonly HttpClient _client;

        public ClienteController()
        {
            _client = new HttpClient();
            _client.BaseAddress = baseAddress;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<ClienteViewModel> clientList = new List<ClienteViewModel>();
            HttpResponseMessage response = _client.GetAsync(_client.BaseAddress + "/Cliente/Get").Result;
            
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                clientList = JsonConvert.DeserializeObject<List<ClienteViewModel>>(data);
            }
            return View(clientList);
        }

        public IActionResult Create() 
        { 
            return View();
        }

        [HttpPost]
        public IActionResult Create(ClienteViewModel model) 
        {
            try
            {
                string data = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(data, Encoding.UTF8, "aplication/Json");
                HttpResponseMessage response = _client.PostAsync(_client.BaseAddress + "/Cliente/Post", content).Result;

                if (response.IsSuccessStatusCode)
                {
                    TempData["successMessage"] = "Cliente Creado.";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.Message;
                return View();
            }
            return View();
        }
    }
}
