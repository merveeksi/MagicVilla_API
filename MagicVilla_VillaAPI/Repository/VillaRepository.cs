using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MagicVilla_VillaAPI.Repository
{
    public class VillaRepository : IVillaRepository
    {
        private readonly ApplicationDbContent _db;
        public VillaRepository(ApplicationDbContent db)
        {
            _db = db;
        }

        public async Task Create(Villa entity)
        {
            await _db.Villas.AddAsync(entity);
            await Save();
        }

        //public Task Create(VillaRepository entity)
        //{
        //    throw new NotImplementedException();
        //}

        public Task<Villa> Get(Expression<Func<Villa>> filter = null, bool tracked = true)
        {
            throw new NotImplementedException();
        }
        Task<List<Villa>> IVillaRepository.GetAll(Expression<Func<Villa>> filter)
        {
            IQueryable<Villa> query = (IQueryable<Villa>)_db.Villas;

        }
        public async Task Remove(Villa entity)
        {
            _db.Villas.Remove(entity);
            await Save();
        }
        public async Task Save()
        {
            await _db.SaveChangesAsync();
        }

        Task<List<Villa>> IVillaRepository.Get(Expression<Func<Villa>> filter, bool tracked)
        {
            throw new NotImplementedException();
        }
    }
}
