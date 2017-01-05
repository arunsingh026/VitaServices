using LEGO.CORE;
using System.Web.Http;
namespace LEGO.SERVICES.Controllers
{
    //[EnableCors(origins: "*", headers: "*", methods: "*")]
    public class BaseAPIController : ApiController
    {
        private readonly IRepository _repository;

        public BaseAPIController()
        {
            _repository = WebApiApplication.Repository;
            
        }

        protected string UserName
        {
            get
            {
                return User == null ? null : User.Identity.Name;
            }
        }
        public IRepository Repository
        {
            get { return _repository; }
        }

    }
}
