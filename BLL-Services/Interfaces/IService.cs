
namespace BLL_Services.Interfaces;

public interface IService<T>
{
    public List<T> Get();
    public T GetById(int id);
    public T Insert(T entity);
    public T Update(T entity);
    public T Delete(int id);
}
