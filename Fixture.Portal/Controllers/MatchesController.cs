using Fixture.BusinessLogic;
using Fixture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Fixture.Portal.Controllers
{
    public class MatchesController : ApiController
    {

        private readonly IMatchService _matchService;

        public MatchesController(IMatchService matchService)
        {
            _matchService = matchService;
        }

        // GET api/standings
        public IEnumerable<Match> Get()
        {
            return _matchService.GetMatches();
        }
    }
}
