using System.Collections.Generic;

namespace Blue_Ward
{
    public class matchData
    {
        public long gameId { get; set; }
        public long gameDuration { get; set; }
        public List<ParticipantDto> participants { get; set; }
        public List<ParticipantIdentityDto> participantIdentities { get; set; }

        public class ParticipantIdentityDto
        {
            public int participantId { get; set; }

            public PlayerDto player { get; set; }

            public class PlayerDto
            {
                public int profileIcon { get; set; }
                public string accountId { get; set; }
                public string matchHistoryUri { get; set; }
                public string currentAccountId { get; set; }
                public string currentPlatformId { get; set; }
                public string summonerName { get; set; }
                public string summonerId { get; set; }
                public string platformId { get; set; }
            }
        }

        public class ParticipantDto
        {
            public int participantId { get; set; }
            public int championId { get; set; }

            public string summonerName { get; set; }
            public string championName { get; set; }

            public ParticipantTimelineDto timeline { get; set; }

            public ParticipantStatsDto stats { get; set; }

            public class ParticipantTimelineDto
            {
                public string lane { get; set; }
                public string role { get; set; }
            }

            public class ParticipantStatsDto
            {
                public int item0 { get; set; }
                public int item1 { get; set; }
                public int item2 { get; set; }
                public int item3 { get; set; }
                public int item4 { get; set; }
                public int item5 { get; set; }
                public int item6 { get; set; }
                public int item7 { get; set; }      //This is wards
                public int champLevel { get; set; }
                public int deaths { get; set; }
                public int kills { get; set; }
                public int assists { get; set; }
                public bool win { get; set; }
            }
        }
        public matchData()
        {

        }
    }
}
