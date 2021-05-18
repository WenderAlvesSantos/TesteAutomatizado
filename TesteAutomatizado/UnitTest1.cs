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
            Config chrome = new Config();

            chrome.Maximizar();

            chrome.Navegar("http://google.com");

            chrome.Escrever("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input", "data atual");

            chrome.Enter();

            chrome.Esperar(2000);

            chrome.Screenshot("teste");

            string copiado = chrome.Copiar("//*[@id='tsf']/div[1]/div[1]/div[2]/div/div[2]/input");

            chrome.Colar(copiado, "//*[@id='tsf']/div[1]/div[1]/div[2]/div/div[2]/input");

            chrome.Esperar(2000);

            chrome.Close();
        }
    }
}