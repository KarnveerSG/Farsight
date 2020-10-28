using System.Collections.Generic;

namespace Blue_Ward
{
    public class championMastery
    {
        public List<ChampionMasteryDTO> championMasteries { get; set; }

        public class ChampionMasteryDTO
        {
            public long championId { get; set; }
            public long championLevel { get; set; }
            public string summonerId { get; set; }
            public int championPoints { get; set; }
        }

        public championMastery()
        {

        }

    }
}
