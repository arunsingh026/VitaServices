using LEGO.CORE;
using LEGO.FDAL.Repository;
using System.Web.Http;

namespace LEGO.SERVICES
{
    public class WebApiApplication : System.Web.HttpApplication
    {

        private static IRepository _repository;
        internal static IRepository Repository
        {
            get { return _repository; }
        }

        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            _repository = _repository ?? new DBRepository();
        }
    }
}
