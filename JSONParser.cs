using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace Farsight
{
    class JSONParser
    {
        public static string APIKEY = "RGAPI-377a3bd4-7c65-489b-ac14-219dfbfbd89f";

        public JSONParser()
        {

        }

        public static string ChampionsFull()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            string jsonString = "";

            using (StreamReader file = File.OpenText(projectDirectory + @"\Farsight\Data\championFull.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject jsonObject = (JObject)JToken.ReadFrom(reader);
                jsonString = jsonObject.ToString();
            }
            return jsonString;
        }
    }
}
