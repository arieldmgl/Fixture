using System.Collections.Generic;

namespace Fixture.Model
{
    public class Team
    {
        public int TeamId { get; set; }

        public string Name { get; set; }

        public string Color { get; set; }

        public int Points { get; set; }

        public int GoalsFor { get; set; }

        public int GoalsAgainst { get; set; }

        public IEnumerable<Player> Players { get; set; }
    }
}
