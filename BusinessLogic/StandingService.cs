using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fixture.Model;

namespace Fixture.BusinessLogic
{
    public class StandingService : IStandingService
    {
        public IEnumerable<Team> GetStandings()
        {
            return new List<Team>
            {
                new Team
                {
                    Name = "Blue Team",
                    Color = "#0000ff",
                    Points = 3,
                    GoalsAgainst = 0,
                    GoalsFor = 2,
                    TeamId = 1
                },
                new Team
                {
                    Name = "Red Team",
                    Color = "#0000ff",
                    Points = 0,
                    GoalsAgainst = 2,
                    GoalsFor = 0,
                    TeamId = 2
                }
            };
        }
    }
}
