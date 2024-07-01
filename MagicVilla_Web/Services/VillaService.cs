using MagicVilla_Utility;
using MagicVilla_Web.Models;
using MagicVilla_Web.Models.Dto;
using MagicVilla_Web.Services.IServices;

namespace MagicVilla_Web.Services {
    public class VillaService : BaseService, IVillaService {
        private readonly IHttpClientFactory _clientFactory;
        private string villaUrl;
        public VillaService(IHttpClientFactory clientFactory, IConfiguration confiquration) : base(clientFactory) {
            _clientFactory = clientFactory;
            string apiUrl = confiquration.GetValue<string>("ServiceUrls:VillaAPI");
            villaUrl = $"{apiUrl}/api/villaAPI/";
        }

        public Task<T> CreateAsync<T>(VillaCreateDTO dto) {
            return SendAsync<T>(new APIRequest() {
                ApiType = SD.ApiType.POST,
                Data = dto,
                Url = villaUrl
            });
        }

        public Task<T> DeleteAsync<T>(Int32 id) {
            return SendAsync<T>(new APIRequest() {
                ApiType = SD.ApiType.DELETE,
                Data = null,
                Url = $"{villaUrl}{id}"
            });
        }

        public Task<T> GetAllAsync<T>() {
            return SendAsync<T>(new APIRequest() {
                ApiType = SD.ApiType.GET,
                Url = villaUrl
            });
        }

        public Task<T> GetAsync<T>(Int32 id) {
            return SendAsync<T>(new APIRequest() {
                ApiType = SD.ApiType.GET,
                Data = null,
                Url = $"{villaUrl}{id}"
            });
        }

        public Task<T> UpdateAsync<T>(VillaUpdateDTO dto) {
            return SendAsync<T>(new APIRequest() {
                ApiType = SD.ApiType.PUT,
                Data = dto,
                Url = villaUrl
            });
        }
    }
}