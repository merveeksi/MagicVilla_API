using MagicVilla_Utility;
using MagicVilla_Web.Models;

namespace MagicVilla_Web.Services.IServices
{
    public interface IBaseService
    {
        APIResponse responseModel { get; set; }
        Task<T> SendAsync<T>(APIRequest apiRequest);
        Task<T> SendAsync<T>(APIRequest apiRequest, SD sD);
    }
}
