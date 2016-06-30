using Fixture.Portal.Models;
using System.Collections.Generic;
using System.Web.Http;
using Fixture.BusinessLogic.Contracts;

namespace Fixture.Portal.Controllers
{
    public class StandingsController : BaseController
    {
        public StandingsController(IStandingService standingService) : base(standingService)
        {
        }

        // GET api/standings
        public IEnumerable<TeamVm> Get()
        {
            return base.Get<TeamVm>();
        }

        
    }
}
