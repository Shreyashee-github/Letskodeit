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

namespace Letskodeit
{

    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            Actions action = new Actions(driver);
            StartStop.Start(driver);
            StartStop.RadioButton(driver);
            StartStop.SelectClass(driver);
            StartStop.MultipleSelect(driver);
            StartStop.Checkbox(driver);
            StartStop.SwitchWindow(driver);
            StartStop.SwitchTab(driver);
            StartStop.WebTables(driver);
            StartStop.EnableOrDisable(driver);
            StartStop.ElementDisplay(driver);
            StartStop.Mousehover(driver);
            StartStop.iFrame(driver);
            StartStop.Stop(driver);
        }
    }
}
