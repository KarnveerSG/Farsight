using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blue_Ward
{
    public class User
    {
        public string id {get; set;}
        public string accountId { get; set; }
        public string puuid { get; set; }
        public string name { get; set; }
        public string profileIconId { get; set; }
        public int summonerLevel { get; set; }   

        public User(string username)
        {
            name = username;
        }

        public void print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("id: " + id + "\n");
            Console.WriteLine("accountId: " + accountId + "\n");
            Console.WriteLine("puuid: " + puuid + "\n");
            Console.WriteLine("profileIconId: " + profileIconId + "\n");
            Console.WriteLine("summonerLevel: " + summonerLevel + "\n");

        }
    }
}
