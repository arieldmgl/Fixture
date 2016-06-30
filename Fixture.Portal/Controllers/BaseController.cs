using System.Collections.Generic;
using System.Web.Http;
using Fixture.BusinessLogic.Contracts;
using Fixture.Portal.Models;

namespace Fixture.Portal.Controllers
{
    public abstract class BaseController : ApiController
    {
        private readonly IBaseService _service;

        protected BaseController(IBaseService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get all items
        /// </summary>
        /// <typeparam name="T">View Model Type</typeparam>
        /// <returns>List of View Models</returns>
        protected virtual IEnumerable<T> Get<T>() where T : IBaseVm, new()
        {
            var vmList = new List<T>();

            foreach (var model in _service.Get())
            {
                var vm = new T();
                vm = (T)vm.FromModel(model);
                vmList.Add(vm);
            }

            return vmList;
        }
    }
}