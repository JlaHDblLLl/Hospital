using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public interface IRepository<T>
    {
        public T Get();
        public void Insert(T item);
        public void Update();

    }
}