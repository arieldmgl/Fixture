using Fixture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fixture.Portal.Models
{
    public class TeamVM
    {
        public int TeamId { get; set; }

        public string Name { get; set; }

        public string Color { get; set; }

        public int Points { get; set; }

        public int GoalsFor { get; set; }

        public int GoalsAgainst { get; set; }

        public int Difference { get; set; }

        public static TeamVM FromModel (Team team)
        {
            return new TeamVM
            {
                TeamId = team.TeamId,
                Name = team.Name,
                Color = team.Color,
                Points = team.Points,
                GoalsFor = team.GoalsFor,
                GoalsAgainst = team.GoalsAgainst,
                Difference = team.GoalsFor - team.GoalsAgainst
            };
        }
    }
}