using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciProjeRepocitory.Repocitory
{
    interface IRepocitory<T> where T:class ,new()
    {
        void Update(T entity);
        void Delete(T entity);
        void Entry(T entity);
        Task<bool> Comit();
        Task<T> Find(int id); // asenkron programlamada T ler Task<T> diye tanımlanıyor.
        Task<ICollection<T>> List();
        DbSet<T> Set();
    }
}
