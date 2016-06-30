using Fixture.BusinessLogic;
using Fixture.Model;
using System.Collections.Generic;
using System.Linq;
using Fixture.BusinessLogic.Contracts;

namespace Fixture.BusinessLogic
{
    public class TeamService : ITeamService
    {
        public Team GetById(int teamId)
        {
            //Temporary mock
            var teams = new List<Team>
            {
                new Team
                {
                    Name = "Blue Team",
                    Color = "#0000ff",
                    Points = 4,
                    GoalsAgainst = 1,
                    GoalsFor = 2,
                    TeamId = 1
                },
                new Team
                {
                    Name = "Red Team",
                    Color = "#ff0000",
                    Points = 1,
                    GoalsAgainst = 2,
                    GoalsFor = 1,
                    TeamId = 2
                }
            };

            return teams.FirstOrDefault(x => x.TeamId == teamId);
        }
    }
}
