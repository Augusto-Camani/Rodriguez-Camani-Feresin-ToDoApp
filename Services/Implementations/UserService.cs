
using AutoMapper;

namespace TAREALABO;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;
    public UserService(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }
    public void AddUser(UserDTO userDTO)
    {
        var user = _mapper.Map<User>(userDTO);
        _userRepository.AddUser(user);
    }

    public void DeleteUser(int id)
    {
        _userRepository.DeleteUser(id);
    }

    public User GetUserById(int id)
    {
        return _userRepository.GetUserById(id);
    }

    public IEnumerable<User> GetUsers()
    {
        return _userRepository.GetUsers();
    }
}
