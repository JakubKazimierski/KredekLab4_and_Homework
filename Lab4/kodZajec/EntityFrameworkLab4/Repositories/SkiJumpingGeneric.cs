using EntityFrameworkLab4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkLab4.Repositories
{
    class SkiJumpingGeneric<T> : ISkiJumpingGeneric<T> where T : class
    {
        /// <summary>
        /// Context bazy danych - połączenie z nia
        /// </summary>
        private readonly SkiJumpingContext _context;

        public SkiJumpingGeneric()
        {
            _context = new SkiJumpingContext();
        }

        /// <summary>
        /// Dodanie nowego rekordu
        /// </summary>
        /// <param name="entity"></param>
        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
            
        }

        public void DeleteById(int id)
        {
            T entities = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(entities);
        }

        /// <summary>
        /// Pobranie query z bazy
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> Get()
        {
            return _context.Set<T>().AsQueryable();
        }

        /// <summary>
        /// Pobranie wszystkich danych z tabeli
        /// </summary>
        /// <returns></returns>
        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();

        }

        /// <summary>
        /// Pobranie obiektu z bazy
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }


        /// <summary>
        /// Zapisanie zmian
        /// </summary>
        public void Save()
        {
            _context.SaveChanges();
        }

        /// <summary>
        /// Aktualizacja danych rekordu
        /// </summary>
        /// <param name="entity"></param>
        public void Update(T entity)
        {
            _context.Entry(entity).CurrentValues.SetValues(entity);
            _context.SaveChanges();
        }
    }
}
