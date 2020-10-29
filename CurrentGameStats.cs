using System.Collections.Generic;

namespace Blue_Ward
{
    class CurrentGameStats
    {
        public long gameId { get; set; }
        public long gameStartTime { get; set; }
        public long gameLength { get; set; }
        public string gameMode { get; set; }
        public List<CurrentGameParticipants> participants { get; set; }

        public class CurrentGameParticipants
        {

            public long championId { get; set; }
            public long profileIconId { get; set; }
            public bool bot { get; set; }
            public long teamId { get; set; }
            public string summonerName { get; set; }
            public string summonerId { get; set; }
            public long spell1Id { get; set; }          //Summoner Spells
            public long spell2Id { get; set; }         //Summoner Spells
            public Perks perks { get; set; }

            public class Perks
            {
                public long perkStyle { get; set; }         //Primary rune tree
                public long perkSubStyle { get; set; }      //Second rune tree
                public List<long> perkIds { get; set; }    //List for IDs for all runes
            }
        }
    }
}
