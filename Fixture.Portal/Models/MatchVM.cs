using Fixture.Model;

namespace Fixture.Portal.Models
{
    public class MatchVm : IBaseVm
    {
        public int MatchId { get; set; }

        public int HomeTeamId { get; set; }

        public string HomeTeamName { get; set; }

        public int AwayTeamId { get; set; }

        public string AwayTeamName { get; set; }

        public int HomeScore { get; set; }

        public int AwayScore { get; set; }

        public IBaseVm FromModel (IBaseModel matchModel)
        {
            var match = (Match) matchModel;

            return new MatchVm
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