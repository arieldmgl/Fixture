using Fixture.Model;

namespace Fixture.Portal.Models
{
    public class MatchVM
    {
        public int MatchId { get; set; }

        public int HomeTeamId { get; set; }

        public string HomeTeamName { get; set; }

        public int AwayTeamId { get; set; }

        public string AwayTeamName { get; set; }

        public int HomeScore { get; set; }

        public int AwayScore { get; set; }

        public static MatchVM FromModel (Match match)
        {
            return new MatchVM
            {
                MatchId = match.MatchId,
                HomeTeamId = match.HomeTeamId,
                HomeTeamName = match.HomeTeamName,
                HomeScore = match.HomeScore,
                AwayTeamId = match.AwayTeamId,
                AwayTeamName = match.AwayTeamName,
                AwayScore = match.AwayScore
            };
        }
    }
}