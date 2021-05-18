using log4net;
using log4net.Config;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace TesteAutomatizado
{
    class Config
    {
        ILog logger = LogManager.GetLogger(typeof(Config));

        IWebDriver driver = new ChromeDriver();

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
            logger.Debug("Going to URL " + URL);
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

        public string Copiar(string xpath)
        {
            IWebElement getphone = driver.FindElement(By.XPath(xpath));
            String getphonetext = getphone.GetAttribute("value");

            return getphonetext;
        }

        public void Colar(string copiado, string xpath)
        {
            IWebElement newphone = driver.FindElement(By.XPath(xpath));
            newphone.Clear();
            newphone.SendKeys(copiado);
        }
    }
}
