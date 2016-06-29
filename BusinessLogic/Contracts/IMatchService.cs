﻿using Fixture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IMatchService
    {
        IEnumerable<Match> GetMatches();
    }
}
