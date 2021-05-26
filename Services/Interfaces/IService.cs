using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IService<T>
    {
        T Add(T obj);
        bool Delete(int id);
        T GetById(int id);
        List<T> Get();
        T Update(T obj);
    }
}