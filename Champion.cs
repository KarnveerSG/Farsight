using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Blue_Ward
{
    class Champion
    {
        public string type { get; set; }
        public string format { get; set; }
        public string version { get; set; }
        public Dictionary<int, string> keys { get; set; }

        public Champion()
        {

        }

        public void DeserialiseJSON(string jsonString)
        {
            var championInfo = JsonConvert.DeserializeObject<Champion>(jsonString);
            this.type = championInfo.type;
            this.format = championInfo.format;
            this.version = championInfo.version;
            this.keys = championInfo.keys;

            foreach (KeyValuePair<int, string> champions in championInfo.keys)
            {
                Console.WriteLine("Champion key: " + champions.Key + " - " + champions.Value);
            }
        }
    }
}
