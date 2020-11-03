using System;

namespace Farsight
{
    public class User
    {
        public string id { get; set; }
        public string accountId { get; set; }
        public string puuid { get; set; }
        public string name { get; set; }
        public string profileIconId { get; set; }
        public int summonerLevel { get; set; }

        public User(string summonerName)
        {
            name = summonerName;
        }

        public User()
        {
            id = " ";
            accountId = " ";
            puuid = " ";
            name = " ";
            profileIconId = " ";
            summonerLevel = 0;

        }

        public void setSummonerName(string summonerName)
        {
            name = summonerName;
        }

        public void print()
        {
            Console.WriteLine("Name: " + name + "\n");
            Console.WriteLine("id: " + id + "\n");
            Console.WriteLine("accountId: " + accountId + "\n");
            Console.WriteLine("puuid: " + puuid + "\n");
            Console.WriteLine("profileIconId: " + profileIconId + "\n");
            Console.WriteLine("summonerLevel: " + summonerLevel + "\n");

        }
    }
}
