using System;
using System.Collections.Generic;
using System.Text;

namespace Tp1
{
    public interface InterfejsCrud<T>
    {
        void Create(T obj);
        T Retrieve(int id);
        void Update(int id, T obj);
        void Delete(int id);
    }
}
