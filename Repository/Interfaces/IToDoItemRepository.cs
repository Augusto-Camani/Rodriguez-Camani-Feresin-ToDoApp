namespace TAREALABO;

public interface IToDoItemRepository
{
    public IEnumerable<ToDoItem> GetToDoItems();

    public ToDoItem GetToDoItemById(int id);

    public void AddToDoItem(ToDoItem toDoItem);

    public void DeleteToDoItem(int id);
}
