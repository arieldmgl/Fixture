using Fixture.Model;

namespace Fixture.Portal.Models
{
    public interface IBaseVm
    {
         IBaseVm FromModel(IBaseModel m);
    }
}