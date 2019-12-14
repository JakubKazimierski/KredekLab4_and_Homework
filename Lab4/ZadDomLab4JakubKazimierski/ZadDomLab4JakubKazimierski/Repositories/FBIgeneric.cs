using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZadDomLab4JakubKazimierski.Models;

namespace ZadDomLab4JakubKazimierski.Repositories
{
    class FBIgeneric<T> : IFBIgeneric<T> where T : class
    {
        /// <summary>
        /// Context of db, connecting with DataBase
        /// </summary>
        private readonly FBIdbContext _context;

        /// <summary>
        /// Constructor
        /// </summary>
        public FBIgeneric()
        {
            _context = new FBIdbContext();
        }

        /// <summary>
        /// Adding new record
        /// </summary>
        /// <param name="entity"></param>
        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        /// <summary>
        /// Delete specific record
        /// </summary>
        /// <param name="id"></param>
        public void DeleteById(int id)
        {
            T entities = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(entities);
        }

        /// <summary>
        /// Download query from DataBase
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> Get()
        {
            return _context.Set<T>().AsQueryable();
        }

        /// <summary>
        /// Download all queries From DataBase
        /// </summary>
        /// <returns></returns>
        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        /// <summary>
        /// Download specific object from DataBase
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        /// <summary>
        /// Save changes in DataBase
        /// </summary>
        public void Save()
        {
            _context.SaveChanges();
        }

        /// <summary>
        /// Update records in DataBase
        /// </summary>
        /// <param name="entity"></param>
        public void Update(T entity)
        {
            _context.Entry(entity).CurrentValues.SetValues(entity);
            _context.SaveChanges();
        }
    }
}
