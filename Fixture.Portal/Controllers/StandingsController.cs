using BusinessLogic;
using Fixture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Fixture.Portal.Controllers
{
    public class StandingsController : ApiController
    {

        private readonly IStandingService _standingService;

        public StandingsController(IStandingService standingService)
        {
            _standingService = standingService;
        }

        // GET api/standings
        public IEnumerable<Team> Get()
        {
            return _standingService.GetStandings();
        }
    }
}
