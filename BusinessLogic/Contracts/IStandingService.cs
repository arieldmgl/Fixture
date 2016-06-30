using System.Collections.Generic;
using Fixture.Model;

namespace Fixture.BusinessLogic.Contracts
{
    public interface IStandingService : IBaseService
    {
        IEnumerable<Team> GetStangings();
    }
}
