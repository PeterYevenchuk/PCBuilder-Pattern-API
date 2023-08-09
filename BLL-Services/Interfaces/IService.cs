
namespace BLL_Services.Interfaces;

public interface IService<T>
{
    public List<T> Get();
    public T GetById(int id);
    public bool Insert(T entity);
    public bool Update(T entity);
    public bool Delete(int id);
}
