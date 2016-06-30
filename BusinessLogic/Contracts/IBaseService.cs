using System.Collections.Generic;
using Fixture.Model;

namespace Fixture.BusinessLogic.Contracts
{
    public interface IBaseService
    {
        /// <summary>
        /// Return all items
        /// </summary>
        /// <returns>List of Models</returns>
        IEnumerable<IBaseModel> Get();
    }
}
