using Fixture.Model;

namespace Fixture.BusinessLogic.Contracts
{
    public interface ITeamService
    {
        Team GetById(int teamId);
    }
}
