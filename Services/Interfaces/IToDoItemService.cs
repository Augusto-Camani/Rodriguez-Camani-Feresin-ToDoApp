namespace TAREALABO;

public interface IToDoItemService
{
    public IEnumerable<ToDoItem> GetToDoItems();

    public ToDoItem GetToDoItemById(int id);

    public void AddToDoItem(ToDoItemDTO toDoItem);

    public void DeleteToDoItem(int id);
}
