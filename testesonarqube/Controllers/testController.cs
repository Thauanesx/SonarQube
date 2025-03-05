using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;

namespace testesonarqube.Controllers
{
    public class testController : Controller
    {
        public IActionResult Index() 
        {
            return Ok('a');
        }
        public double  BugTeste()
        {
            return 5/2; 
        }
        public string Duplicacao()
        {
          return "teste";
        }
        public string Duplicacao2()
        {
          return "teste";
        }
    } 
}
