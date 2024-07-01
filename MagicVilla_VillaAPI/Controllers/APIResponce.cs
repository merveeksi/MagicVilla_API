
using MagicVilla_VillaAPI.Models.Dto;
using System.Net;

namespace MagicVilla_VillaAPI.Controllers
{
	public class APIResponce
	{
		public bool IsSuscess { get; internal set; }
		public List<string> ErrorMessage { get; internal set; }
		public HttpStatusCode StatusCode { get; internal set; }
		public List<VillaDTO> Result { get; internal set; }
		public bool IsSuccess { get; internal set; }
	}
}