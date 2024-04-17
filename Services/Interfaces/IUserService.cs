using System.Collections;

namespace TAREALABO;

public interface IUserService
{
    public IEnumerable<User> GetUsers();
    public User GetUserById(int id);
    public void AddUser(UserDTO user);
    public void DeleteUser(int id);
}
