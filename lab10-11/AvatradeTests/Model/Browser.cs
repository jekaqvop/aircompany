using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.Model
{
    class Browser
    {
        string _browserName = "";
        static List<string> parametrs = new List<string>();
        // "--headless", "--disable-gpu", "--window-size=1920,1200", "--ignore-certificate-errors", "--disable-extensions", "--no-sandbox", "--disable-dev-shm-usage" 

        public string BrowserName
        {
            get => _browserName;
            set => _browserName = value;
        }

        public List<string> StartParametrs
        {
            get => parametrs;
            set => parametrs = value;
        }
    }
}
