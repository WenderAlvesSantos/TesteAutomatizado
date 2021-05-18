using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using static TesteAutomatizado.Config;

namespace TesteAutomatizado
{
    [TestClass]
    public class Tests
    {
        [Test]
        public static void AmbienteTeste()
        {
            Metodos metodos = new Metodos();

            metodos.Maximizar();

            metodos.Navegar("http://google.com");

            metodos.Escrever("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input", "data atual");

            metodos.Enter();

            metodos.Click("//*[@id='gb']/div/div[1]/a");

            metodos.Esperar(2000);

            metodos.Screenshot("teste");

            metodos.Alerta("Teste Concluido");

            metodos.Esperar(2000);

            metodos.Close();
        }
    }
}