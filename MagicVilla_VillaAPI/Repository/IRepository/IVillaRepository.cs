using MagicVilla_VillaAPI.Models;
using System.Linq.Expressions;

namespace MagicVilla_VillaAPI.Repository.IRepostiory
{
	public interface IVillaRepository : IRepository<Villa>
	{
		Task RemaveAsync(Villa villa);
		Task<Villa> UpdateAsync(Villa entity);

	}
}