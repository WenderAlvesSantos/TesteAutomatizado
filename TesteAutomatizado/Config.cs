using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;

namespace TesteAutomatizado
{
    public class Config
    {
        public class Metodos
        {
            ChromeDriver driver = new ChromeDriver();

            public IWebDriver teste;

            public string screenshotsPasta = @"C:\Users\x000418\Pictures\Print Teste Automatizados\";

            string counter = DateTime.Now.Ticks.ToString();

            public void Maximizar()
            {
                driver.Manage().Window.Maximize();
            }

            public void Escrever(string XPath, string texto)
            {
                driver.FindElement(By.XPath(XPath)).SendKeys(texto);
            }

            public void Navegar(string URL)
            {
                driver.Navigate().GoToUrl(URL);
            }

            public void Enter()
            {
                driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            }

            public void Click(string XPath)
            {
                driver.FindElement(By.XPath(XPath)).Click();
            }

            public void Close()
            {
                driver.Close();
            }

            public void Esperar(int tempo)
            {
                Thread.Sleep(tempo);
            }

            public void Screenshot(string nomeArquivo)
            {
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                ss.SaveAsFile(screenshotsPasta + nomeArquivo + "_" + counter + ".png",
                ScreenshotImageFormat.Png);
            }

            public void Alerta(string texto)
            {
                driver.SwitchTo().Alert().Accept();
            }

        }

    }
}
