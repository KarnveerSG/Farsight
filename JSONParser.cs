using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace Farsight
{
    class JSONParser
    {
        public static string APIKEY = "RGAPI-e073faea-60ff-4bd7-a961-f797bc273912";

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
