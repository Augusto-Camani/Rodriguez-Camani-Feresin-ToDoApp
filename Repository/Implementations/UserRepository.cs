using System.Collections;
using System.Linq;

namespace TAREALABO;

public class UserRepository : Repository, IUserRepository
{

    public UserRepository(ToDoContext context) : base(context)
    {
    }
    public void AddUser(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
    }

    public void DeleteUser(int id)
    {
        _context.Users.Remove(GetUserById(id));
    }

    public User GetUserById(int id)
    {
        return _context.Users.SingleOrDefault(u => u.UserId == id);
    }

    public IEnumerable<User> GetUsers()
    {
        return _context.Users;
    }
}
