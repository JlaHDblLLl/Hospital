using System;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class Repository<T> : IRepository<T>
    {
        IEnumerable<T?> list;
        public T Find(Func<T, bool> func)
        {
            foreach(var item in list)
            {
                if(func(item))
                    return item;
            }
            return null;
        }

        public T Get(int i)
        {
            return list.ElementAt(i);
        }

        public IEnumerable<T> GetAll()
        {
            return list;
        }

        public void Insert(T item)
        {
            list = list.Concat(new[] { item });
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}