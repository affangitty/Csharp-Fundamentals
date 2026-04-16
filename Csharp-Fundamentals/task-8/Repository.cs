using System.Collections.Generic;
using System.Linq;

public class Repository<T> : IRepository<T> where T : class
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }

    public List<T> GetAll()
    {
        return items;
    }

    public T GetById(int id)
    {
        return items.FirstOrDefault(x => (int)x.GetType().GetProperty("Id").GetValue(x) == id);
    }

    public void Update(int id, T newItem)
    {
        var item = GetById(id);
        if (item != null)
        {
            items.Remove(item);
            items.Add(newItem);
        }
    }

    public void Delete(int id)
    {
        var item = GetById(id);
        if (item != null)
        {
            items.Remove(item);
        }
    }
}