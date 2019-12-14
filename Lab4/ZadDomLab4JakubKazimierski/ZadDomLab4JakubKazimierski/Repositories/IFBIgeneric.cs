using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadDomLab4JakubKazimierski.Repositories
{
    interface IFBIgeneric<T> where T : class
    {
        /// <summary>
        /// Methods of interface, to override in class inheriting form This Iterface
        /// </summary>
        /// <returns></returns>
        List<T> GetAll();
        IQueryable<T> Get();
        T GetById(int id);
        void DeleteById(int id);
        void Update(T entity);
        void Create(T entity);
        void Save();
    }
}
