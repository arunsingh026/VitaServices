
namespace LEGO.CORE
{
    public interface IUserManagementRepository : IRepository
    {
        bool ValidateUser(string useremail, string password);
        bool ValidateOnlyUser(string useremail);
        bool ActiaveUser(string useremail);
    }
}
