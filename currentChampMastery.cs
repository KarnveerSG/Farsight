using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blue_Ward
{
    class currentChampMastery
    {
        public ChampionMasteryDTO currentMastery { get; set; }
        public string summonerName { get; set; }

        public class ChampionMasteryDTO
        {
            public long championId { get; set; }
            public string championName { get; set; }
            public long championLevel { get; set; }
            public string summonerId { get; set; }
            public int championPoints { get; set; }
        }
        public currentChampMastery(string temp) {  //Constructor created to fill in temp objects when currentChampMastery object is used in a list externally.
            summonerName = "temp";
            this.currentMastery = new ChampionMasteryDTO();
            this.currentMastery.championId = 0;
            this.currentMastery.championLevel = 0;
            this.currentMastery.championPoints = 0;
            this.currentMastery.championName = "";
            this.currentMastery.summonerId = "";
        }
    }
}
