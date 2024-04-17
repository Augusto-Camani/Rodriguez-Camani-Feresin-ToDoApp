using System.Collections;

namespace TAREALABO;

public interface IUserRepository
{
    public IEnumerable<User> GetUsers();
    public User GetUserById(int id);
    public void AddUser(User user);
    public void DeleteUser(int id);
}
