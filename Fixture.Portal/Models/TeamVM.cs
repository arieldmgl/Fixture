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

        public static TeamVM FromModel (Team team)
        {
            return new TeamVM { TeamId = team.TeamId, Name = team.Name, Color = team.Color };
        }
    }
}