public class Repository<T> where T : Entity
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }

    public T? GetById(int id)
    {
        foreach (T item in items)
        {
            if (item.Id == id)
            {
                return item;
            }
        }

        return null;
    }
}
