using AutoMapper;

namespace TAREALABO;

public class ToDoItemService : IToDoItemService
{
    private readonly IToDoItemRepository _toDoItemRepository;
    private readonly IMapper _mapper;
    public ToDoItemService(IToDoItemRepository toDoItemRepository, IMapper mapper)
    {
        _toDoItemRepository = toDoItemRepository;
        _mapper = mapper;
    }
    public void AddToDoItem(ToDoItemDTO toDoItemDTO)
    {
        var toDoItem = _mapper.Map<ToDoItem>(toDoItemDTO);
        _toDoItemRepository.AddToDoItem(toDoItem);
    }

    public void DeleteToDoItem(int id)
    {
        _toDoItemRepository.DeleteToDoItem(id);
    }

    public ToDoItem GetToDoItemById(int id)
    {
        return _toDoItemRepository.GetToDoItemById(id);
    }

    public IEnumerable<ToDoItem> GetToDoItems()
    {
        return _toDoItemRepository.GetToDoItems();
    }
}
