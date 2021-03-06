﻿using System.Collections.Generic;

namespace Farsight
{
    public class championMastery
    {
        public List<ChampionMasteryDTO> championMasteries { get; set; }
        public string summonerName { get; set; }

        public class ChampionMasteryDTO
        {
            public long championId { get; set; }
            public string championName { get; set; }
            public long championLevel { get; set; }
            public string summonerId { get; set; }
            public int championPoints { get; set; }
        }

        public championMastery()
        {

        }

    }
}
