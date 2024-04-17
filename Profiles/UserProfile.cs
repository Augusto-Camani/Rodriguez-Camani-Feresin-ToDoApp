using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;

namespace TAREALABO;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<UserDTO, User>();
        CreateMap<User, UserDTO>();
    }
}
