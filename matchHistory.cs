using System.Collections.Generic;

namespace Blue_Ward
{
    public class matchHistory
    {
        public int startIndex { get; set; }
        public int totalGames { get; set; }
        public int endIndex { get; set; }
        public List<MatchReferenceDto> matches { get; set; }
        //Inner Class
        public class MatchReferenceDto
        {
            public long gameId { get; set; }
            public string role { get; set; }
            public int season { get; set; }
            public int champion { get; set; }
            public string platformId { get; set; }
            public string queue { get; set; }
            public string lane { get; set; }
            public long timestamp { get; set; }
        }
        //Constructor
        public matchHistory()
        {

        }
    }
}