using System.Collections.Generic;
using Fixture.Model;

namespace Fixture.BusinessLogic.Contracts
{
    public interface IMatchService : IBaseService
    {
        IEnumerable<Match> GetMatches();
    }
}
