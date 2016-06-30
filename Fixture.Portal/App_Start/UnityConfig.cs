using Fixture.BusinessLogic;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace Fixture.Portal
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IStandingService, StandingService>();
            container.RegisterType<IMatchService, MatchService>();
            container.RegisterType<ITeamService, TeamService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}