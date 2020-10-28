using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace Blue_Ward
{
    class JSONParser
    {
        public JSONParser()
        {

        }

        public static string ChampionsFull()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            string jsonString = "";

            using (StreamReader file = File.OpenText(projectDirectory + @"\Blue Ward\Data\championFull.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject jsonObject = (JObject)JToken.ReadFrom(reader);
                jsonString = jsonObject.ToString();
            }
            return jsonString;
        }
    }
}
