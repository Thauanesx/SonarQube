using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace testesonarqube.Controllers
{
    public class testController2:ControllerBase
    {
        public IActionResult Index()
        {
            return Ok('a');
        }
        public double BugTeste()
        {
            return 5 / 2;
        }
        private const string CODE = "bounteous";
        private int callCount = 0;

        public string GetCode()
        {
            callCount++;
            return CODE;
        }

        public string GetName()  // Noncompliant
        {
            callCount++;
            return CODE;
        }
        public void GetName(int param)  // Noncompliant
        {
            var tripleDES1 = new TripleDESCryptoServiceProvider(); // Noncompliant: Triple DES is vulnerable to meet-in-the-middle attack

            var simpleDES = new DESCryptoServiceProvider(); // Noncompliant: DES works with 56-bit keys allow attacks via exhaustive search

            var RC2 = new RC2CryptoServiceProvider(); // Noncompliant: RC2 is vulnerable to a related-key attack

        }
    }
}
