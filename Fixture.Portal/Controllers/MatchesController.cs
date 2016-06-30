using Fixture.Portal.Models;
using System.Collections.Generic;
using Fixture.BusinessLogic.Contracts;

namespace Fixture.Portal.Controllers
{
    public class MatchesController : BaseController
    {
        public MatchesController(IMatchService matchService) : base(matchService)
        {
        }

        // GET api/matches
        public IEnumerable<MatchVm> Get()
        {
            return base.Get<MatchVm>();
        }
    }
}
