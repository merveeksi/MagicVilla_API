using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MagicVilla_VillaAPI.Repository
{
#pragma warning disable CS1956 // Member implements interface member with multiple matches at run-time
    public class VillaRepository : Repository<Villa>, IVillaRepository
#pragma warning restore CS1956 // Member implements interface member with multiple matches at run-time
    {
        private readonly ApplicationDbContext _db;
        public VillaRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }
        
        public async Task<Villa> UpdateAsync(Villa entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.Villas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
