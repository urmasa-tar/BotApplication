using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BotTryApp
{
    internal class jsonReader
    {
        public string token { get; set; }
        public string prefix { get; set; }

        public async Task ReadJSON()
        {
            using (StreamReader sr = new StreamReader("config.json"))
            {
                string json = await sr.ReadToEndAsync();
                JSONstructer data = JsonConvert.DeserializeObject<JSONstructer>(json);

                this.token = data.token;
                this.prefix = data.prefix;

            }
        }
    }

    internal sealed class JSONstructer
    {
        public string token { get; set; }
        public string prefix { get; set; }
    }
}
