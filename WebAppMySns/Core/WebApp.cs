using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMySns
{
    public class WebApp
    {
        //Singleton pattern
        public static WebApp Current { get; private set; } = new WebApp();

        public MySnsConfig Config { get; set; }

        private WebApp() { }
        public void Initialize()
        {
            var json = File.ReadAllText("C:\\Dev\\MySnsConfig.json");
            this.Config = JsonConvert.DeserializeObject<MySnsConfig>(json);
        }
    }
}
