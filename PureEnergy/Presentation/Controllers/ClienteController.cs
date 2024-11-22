using Microsoft.AspNetCore.Mvc;
using PureEnergy.Application.DTOs;
using PureEnergy.Application.Interfaces;

namespace PureEnergy.Presentation.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteApplicationService _clienteApplicationService;

        public ClienteController(IClienteApplicationService clienteApplicationService)
        {
            _clienteApplicationService = clienteApplicationService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Index()
        {
            var clientes = _clienteApplicationService.GetAll();

            return View(clientes);
        }

    
        [HttpPost]
        public IActionResult Create(ClienteDTO clienteDTO)
        {
            if (ModelState.IsValid)
            {
                _clienteApplicationService.Add(clienteDTO);

                return RedirectToAction("Index");
            }

            return View(clienteDTO);
        }
      
        [HttpGet]
        public IActionResult Details(int id)
        {
            var cliente = _clienteApplicationService.GetById(id);

            return View(cliente);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var cliente = _clienteApplicationService.GetById(id);

            return View(cliente);
        }

        [HttpPost]
        public IActionResult DeleteForm(int id)
        {
            var cliente = _clienteApplicationService.DeleteById(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var cliente = _clienteApplicationService.GetById(id);

            return View(cliente);
        }

        [HttpPost]
        public IActionResult Edit(int id, ClienteDTO clienteDTO)
        {
            if (ModelState.IsValid)
            {
                _clienteApplicationService.Update(id, clienteDTO);

                return RedirectToAction("Index");
            }

            return View(clienteDTO);
        }
    }
}
