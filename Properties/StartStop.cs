using Letskodeit.Properties;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Letskodeit.Properties
{
    class StartStop
    {
        public static void Start(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            Console.WriteLine("Test Case started: ");
            Thread.Sleep(2000);
            Console.WriteLine("Automation on Letskodeit started");
            Thread.Sleep(1000);

            driver.Manage().Window.Maximize();

            //Giving Website
            driver.Navigate().GoToUrl("https://courses.letskodeit.com/practice");
            Thread.Sleep(2000);
        }

        public static void RadioButton(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            //Choose BMW
            driver.FindElement(By.XPath("//label[@for='bmw']")).Click();
            //driver.FindElement(By.Id("bmwradio")).Click();
            Thread.Sleep(1000);


            //Choose Benz
            //driver.FindElement(By.XPath("//label[@for='benz']")).Click();
            //driver.FindElement(By.Id("benzradio")).Click();
            //Thread.Sleep(1000);


            //Choose Honda
            //driver.FindElement(By.XPath("//label[@for='honda']")).Click();
            //driver.FindElement(By.Id("hondaradio")).Click();
            //Thread.Sleep(1000);
        }

        public static void SelectClass(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.FindElement(By.XPath("//select[@id='carselect']")).Click();
            //driver.FindElement(By.XPath("//select[@id='carselect']")).Clear();
            Thread.Sleep(1000);

            //Choose Benz
            driver.FindElement(By.XPath("//option[@value='benz']")).Click();
            Thread.Sleep(1000);

            //Choose honda
            //driver.FindElement(By.XPath("//option[@value='honda']")).Click();
            //Thread.Sleep(1000);

            //Choose bmw
            //driver.FindElement(By.XPath("//option[@value='bmw']")).Click();
            //Thread.Sleep(1000);
        }

        public static void MultipleSelect(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.FindElement(By.XPath("//option[@value='orange']")).Click();
            Thread.Sleep(1000);
        }

        public static void Checkbox(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            //Choose BMW
            driver.FindElement(By.XPath("//input[@id='bmwcheck']")).Click();
            Thread.Sleep(1000);


            //Choose Benz
            driver.FindElement(By.XPath("//input[@id='benzcheck']")).Click();
            Thread.Sleep(1000);


            //Choose Honda
            driver.FindElement(By.XPath("//input[@id='hondacheck']")).Click();
            Thread.Sleep(1000);
        }

        public static void SwitchWindow(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.FindElement(By.XPath("//button[@id='openwindow']")).Click();
            Thread.Sleep(1000);

            string a;
            string b;
            a = driver.WindowHandles[0];
            b = driver.WindowHandles[1];

            Console.WriteLine("New window is openning");
            Thread.Sleep(1000);
            driver.SwitchTo().Window(b);
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,200)");
            js.ExecuteScript("window.scrollBy(0,200)");
            js.ExecuteScript("window.scrollBy(0,-400)");
            Thread.Sleep(2000);
            driver.Manage().Window.Minimize();
            driver.Close();
            Console.WriteLine("New window is closed");
            Thread.Sleep(2000);
            driver.SwitchTo().Window(a);


        }

        public static void SwitchTab(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.FindElement(By.XPath("//a[@id='opentab']")).Click();
            Thread.Sleep(1000);

            string a;
            string b;
            a = driver.WindowHandles[0];
            b = driver.WindowHandles[1];

            Console.WriteLine("New tab is openning");
            Thread.Sleep(1000);
            driver.SwitchTo().Window(b);
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,200)");
            js.ExecuteScript("window.scrollBy(0,200)"); 
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,-400)");
            Thread.Sleep(2000);
            driver.Manage().Window.Minimize();
            driver.Close();
            Console.WriteLine("New tab is closed");
            Thread.Sleep(2000);
            driver.SwitchTo().Window(a);

        }

        public static void SwitchToAlert(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            //Alert Button
            driver.FindElement(By.XPath("//input[@id='name']")).SendKeys("Test is successful");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='alertbtn']")).Click();
            Thread.Sleep(1000);

            //Confirm Button
            driver.FindElement(By.XPath("//input[@id='name']")).SendKeys("Confirm Test is successful");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='alertbtn']")).Click();
            Thread.Sleep(1000);

        }

        public static void WebTables(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        }

        public static void EnableOrDisable(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.FindElement(By.XPath("//input[@id='enabled-example-input']")).SendKeys("Test is successful");
            Thread.Sleep(1000);

            //Disable button
            driver.FindElement(By.XPath("//input[@id='disabled-button']")).Click();
            Thread.Sleep(1000);

            //Enable button
            driver.FindElement(By.XPath("//input[@id='enabled-button']")).Click();
            Thread.Sleep(1000);

        }

        public static void ElementDisplay(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.FindElement(By.XPath("//input[@id='displayed-text']")).SendKeys("Test is successful");
            Thread.Sleep(1000);

            //Hide Element
            driver.FindElement(By.XPath("//input[@id='hide-textbox']")).Click();
            Thread.Sleep(1000);

            //Show Element
            driver.FindElement(By.XPath("//input[@id='show-textbox']")).Click();
            Thread.Sleep(1000);
        }

        public static void Mousehover(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.FindElement(By.XPath("//button[@id='mousehover']")).Click();
            Thread.Sleep(1000);

            //Choose Top
            driver.FindElement(By.XPath("//a[@href='#top']")).Click();
            Thread.Sleep(1000);

            //Choose Reload
            //driver.FindElement(By.XPath("//a[text()='Reload']")).Click();
            //Thread.Sleep(1000);
        }
        
        public static void iFrame(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            //Choose Home
            driver.FindElement(By.XPath("//*[@id='navbar-inverse-collapse']/ul/li[1]/a")).Click();
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,200)");

            //Choose Courses
            driver.FindElement(By.XPath("//a[@href='/courses']")).Click();
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,200)");

            //Choose categories in Courses
            driver.FindElement(By.XPath("//select[@name='categories']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//option[@value='2022']")).Click();
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,200)");

            //Choose Support
            driver.FindElement(By.XPath("//a[@href='/support']")).Click();
            Thread.Sleep(8000);

        }


        public static void Stop(IWebDriver driver)
        {

            Console.WriteLine("Automation on Letskodeit ended");
            Thread.Sleep(1000);
            driver.Manage().Window.Minimize();
            Thread.Sleep(2000);
            driver.Close();
            driver.Dispose();
            driver.Quit();
            Console.WriteLine("Test Case ended: ");
            Thread.Sleep(2000);

        }
    }
}
