using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OgrenciProjeRepocitory.Models.Data;

namespace OgrenciProjeRepocitory.Repocitory
{
    
    public class BaseRepocitory<T> : IRepocitory<T> where T : class, new()
    {
        OgrenciContext _db;
        public BaseRepocitory(OgrenciContext db)
        {
            _db = db;
        }

        public async Task<bool> Comit() // async programlamayı asekronize hale getirmesi için kullanılıyor. Ve geri dönüş tipi olan herşey de Task<> içine alınıyor.
        {
            return await _db.SaveChangesAsync()>0; // büyük 0 olayı asenkron olayının çalışıp çalışmadığı anlamına geliyor 0 dan büyükse direk doğrudur ve çalışır.
            //try buda 2 ci yol üsttekini yapmasak böyle bir yol izleyebiliriz.
            //{
            //  await  _db.SaveChangesAsync();
            //    return true;
            //}
            //catch (Exception)
            //{

            //    return false;
            //}
        }

        public  void Delete(T entity)
        {
            _db.Entry(entity).State = EntityState.Deleted;
            
        }

        public  void Entry(T entity)
        {
            _db.Entry(entity).State = EntityState.Added;
           
        }

        public async Task<T> Find(int id)
        {
          return await  Set().FindAsync(id);
        }

        public async Task<ICollection<T>> List()
        {
            return await Set().ToListAsync();
        }

        public DbSet<T> Set()
        {
           return  _db.Set<T>();
        }

        public  void Update(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
           
        }
    }
}
