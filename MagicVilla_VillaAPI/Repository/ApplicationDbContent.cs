
using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Repository
{
    public class ApplicationDbContent : DbContext
    {
        public DbSet<Villa>Villas { get; internal set; }

      
    }
}