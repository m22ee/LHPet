using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "Maria Cecilia Nogueira", "858.132.960-43","maryceci@hotmail.com", "Belly");
        Cliente cliente2 = new Cliente(02, "Mario Carlos Nogueira", "859.131.966-45","maroc@hotmail.com", "Delly");        
        Cliente cliente3 = new Cliente(03, "Raimunda Cecilia Nogueira", "958.232.860-33","rdaceci@hotmail.com", "Molly");
        Cliente cliente4 = new Cliente(04, "Maria Carmo Nogueira", "878.122.940-41","maricar@hotmail.com", "Dindo");   
        Cliente cliente5 = new Cliente(05, "Francisco Jose Nogueira", "058.032.060-03","fcono@hotmail.com", "Nenem");
        
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes; 

        
        Fornecedor fornecedor1 = new Fornecedor(01, "Maroca Ltda", "12.181.112/0001-10","maroca@hotmail.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "Mar Bicho Ltda", "11.101.113/0001-15","marbi@hotmail.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "Bicho da Seda S/A", "96.223.112/0001-15","bichos@hotmail.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "Birosca Ltda", "22.999.334/0001-33","biroc@hotmail.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "Maroca2 Ltda", "12.181.112/0002-31","maroc@hotmail.com");
        
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;
        
        
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
}
