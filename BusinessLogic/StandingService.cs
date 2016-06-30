using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fixture.BusinessLogic.Contracts;
using Fixture.Model;

namespace Fixture.BusinessLogic
{
    public class StandingService : IStandingService, IBaseService
    {
        public IEnumerable<Team> GetStangings()
        {
            //Temporary mock
            return new List<Team>
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
        }

        IEnumerable<IBaseModel> IBaseService.Get()
        {
            return GetStangings();
        }
    }
}
