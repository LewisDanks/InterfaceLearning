using BusinessLogic.Models;

namespace BusinessLogic
{
    public interface IDataDriver
    {
        IEnumerable<User> GetUsers();
    }
}