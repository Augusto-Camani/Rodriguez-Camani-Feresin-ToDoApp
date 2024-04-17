namespace TAREALABO;

public class Repository : IRepository
{
    internal readonly ToDoContext _context;
    public Repository(ToDoContext context)
    {
        _context = context;
    }
    public bool SaveChanges()
    {
        return _context.SaveChanges() >= 0;

    }
}
