using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Blue_Ward
{
    public class Champion
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
            this.keys = ProcessChampions(this.keys);

            foreach (KeyValuePair<int, string> champions in championInfo.keys)
            {
                Console.WriteLine("Champion key: " + champions.Key + " - " + champions.Value);
            }
        }

        public Dictionary<int, string> ProcessChampions(Dictionary<int, string> allChampions) //Adds spaces to champions; Example : 'TwistedFate' --> 'Twisted Fate'
        {
            Dictionary<int, string> processedChampions = new Dictionary<int, string>();

            foreach (int key in allChampions.Keys)
            {
                keys.TryGetValue(key, out string champName);

                if (champName == "MonkeyKing")
                {
                    champName = "Wukong";
                }

                string newValue = Regex.Replace(champName, "([a-z])([A-Z])", "$1 $2");

                processedChampions.Add(key, newValue);
            }
            return processedChampions;
        }
    }
}
