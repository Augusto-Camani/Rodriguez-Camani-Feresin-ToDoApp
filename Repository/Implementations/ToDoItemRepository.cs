
namespace TAREALABO;

public class ToDoItemRepository : Repository, IToDoItemRepository
{
    public ToDoItemRepository(ToDoContext context) : base(context)
    {
    }

    public void AddToDoItem(ToDoItem toDoItem)
    {
        _context.ToDoItems.Add(toDoItem);
        _context.SaveChanges();
    }

    public void DeleteToDoItem(int id)
    {
        _context.Remove(GetToDoItemById(id));
        _context.SaveChanges();
    }

    public ToDoItem GetToDoItemById(int id)
    {
        return _context.ToDoItems.SingleOrDefault(t => t.ToDoId == id);
    }

    public IEnumerable<ToDoItem> GetToDoItems()
    {
        return _context.ToDoItems;
    }
}
