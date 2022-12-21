using System.Collections.Generic;

namespace TacticPatterns
{
    public interface IRepository<T>
    {
        public IEnumerable<T> GetAll();
        public T GetById(int id);
        public int Add(T elem);
        public void Update(T elem);
        public void Remove(int id);
    }
}