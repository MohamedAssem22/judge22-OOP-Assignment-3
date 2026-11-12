namespace src;

public class Store<T> where T : IHasId
{
    
    private readonly Dictionary<int, T> _items = new Dictionary<int, T>(); 
    public void Add(T item)
    {
        if (_items.ContainsKey(item.Id))
            throw new InvalidOperationException("Item is already in the store.."); 
        _items.Add(item.Id , item);
    }

    public T? GetById(int id)
    {
        // return _items[id];
        return _items.TryGetValue(id, out var item) ? item : default; // to avoid exception(key not found)
    }

    public IReadOnlyCollection<T> GetAll()
    {
        return _items.Values.ToList().AsReadOnly(); 
    }

    public void Remove(int id)
    {
        _items.Remove(id); 
    }    
}