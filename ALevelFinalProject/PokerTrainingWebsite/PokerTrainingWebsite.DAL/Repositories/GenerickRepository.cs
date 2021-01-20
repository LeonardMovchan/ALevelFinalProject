using PokerTrainingWebsite.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerTrainingWebsite.DAL.Repositories
{
    public class GenerickRepository<T>  : IGenerickRepository<T> where T : class
    {
        private readonly PokerTrainingContext _ctx;
        private readonly DbSet<T> _DbSet;

        public GenerickRepository(PokerTrainingContext ctx)
        {
            _ctx = ctx;
            _DbSet = _ctx.Set<T>();
        }

        public void Add(T model)
        {
            _DbSet.Add(model);
            SaveChanges();
        }

        public void Remove(int id)
        {
            var model = _DbSet.Find(id);
            _DbSet.Remove(model);
            SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _DbSet.AsNoTracking();
        }

        public void Update(T model)
        {
            _ctx.Entry(model).State = EntityState.Modified;
            SaveChanges();
        }

        public T GetById(int id)
        {
            return _DbSet.Find(id);
        }

        public void SaveChanges()
        {
            _ctx.SaveChanges();
        }
    }
}
