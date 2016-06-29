using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
