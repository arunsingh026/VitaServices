using LEGO.CORE;
using LEGO.FDAL.DBContext;
using System;
using System.Linq;
using System.Web.Http;
namespace LEGO.SERVICES.Controllers
{
    public class AccountController : BaseAPIController
    {
        [HttpGet]
        [Route("Account/LoginAttemt")]
        public IHttpActionResult GetLogin(string Email, string Password)
        {
            var umRepository = Repository as IUserManagementRepository;
            var Model = new CoreUser();
            if (Email == null & Password == null)
            { 
                return null;
            }

            Model.CoreEmail = Email;
            Model.CorePassword = Password;

            if (umRepository == null)
            {
                //do some stuff
            }

            if (Model == null)
                return null;

            var uservalidate = umRepository.ValidateUser(Model.CoreEmail, Model.CorePassword);
            if (uservalidate)
            {

            }
            else
            {

            }
            return Ok(uservalidate);
        }

        [HttpGet]
        [Route("Account/AllMember")]
        public IHttpActionResult GetALLUser()
        {
            var allmembers = Repository.GetAll<CoreUser>().ToList();
            return Ok(allmembers);
        }

        //[HttpGet]
        //[Route("Account/Getmember")]
        //public IHttpActionResult GetMember(Guid id)
        //{
        //    var member = Repository.Get<CoreMember>(id);
        //    return Ok(member);

        //}

        [HttpPost]
        [Route("Account/Register")]
        public bool Register(AccountServices_call model)
        {
            if (model != null)
            {
                
                return true;
            }

            else
            {
                return false;
            }
        }


    }



    public class AccountServices_call
    {
        public virtual string Name { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
        public virtual string Address { get; set; }
    }
}
