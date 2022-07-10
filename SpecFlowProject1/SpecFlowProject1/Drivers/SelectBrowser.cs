using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using static SpecFlowProject1.Constant.Enums.BrowserElemets;

namespace SpecFlowProject1.Drivers
{
    public class SelectBrowser
    {
        public static Object GetBrowser(string browserType)
        {
            Enum.TryParse<BrowserElemetsType>(browserType, out var browser);
            switch (browser)
            {
                case BrowserElemetsType.Chrome:
                    return new ChromeDriver();
                case BrowserElemetsType.Firefox:
                    return new FirefoxDriver();
                default:
                    return new ChromeDriver();
            }
        }
    }
}
