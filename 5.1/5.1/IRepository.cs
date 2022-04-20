using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public interface IRepository<T>
    {
        public T Get(int i);
        public void Insert(T item);
        public T Find(Func<T, bool> func);
        public IEnumerable<T> GetAll();
        public void Update();

    }
}