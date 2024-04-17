using AutoMapper;

namespace TAREALABO;

public class ToDoItemProfile : Profile
{
    public ToDoItemProfile()
    {
        CreateMap<ToDoItemDTO, ToDoItem>();
        CreateMap<ToDoItem, ToDoItemDTO>();
    }
}
