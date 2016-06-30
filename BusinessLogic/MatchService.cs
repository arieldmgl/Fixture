using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fixture.Model;

namespace Fixture.BusinessLogic
{
    public class MatchService : IMatchService
    {
        private readonly ITeamService _teamService;

        public MatchService(ITeamService teamService)
        {
            _teamService = teamService;
        }
        public IEnumerable<Match> GetMatches()
        {
            //Temporary mock
            var matches =  new List<Match>
            {
                new Match
                {
                    MatchId = 1,
                    HomeTeamId = 1,
                    AwayTeamId = 2,
                    HomeScore = 2,
                    AwayScore = 0
                },
                new Match
                {
                    MatchId = 2,
                    HomeTeamId = 2,
                    AwayTeamId = 1,
                    HomeScore = 1,
                    AwayScore = 1
                }
            };

            foreach (var m in matches)
            {
                m.HomeTeamName = _teamService.GetTeamById(m.HomeTeamId).Name;
                m.AwayTeamName = _teamService.GetTeamById(m.AwayTeamId).Name;
            }

            return matches;
        }
    }
}
