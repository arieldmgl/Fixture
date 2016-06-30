using Fixture.BusinessLogic;
using Fixture.Portal.Models;
using System.Collections.Generic;
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

        // GET api/matches
        public IEnumerable<MatchVM> Get()
        {
            var result = new List<MatchVM>();

            foreach (var m in _matchService.GetMatches())
            {
                result.Add(MatchVM.FromModel(m));
            }

            return result;
        }
    }
}
