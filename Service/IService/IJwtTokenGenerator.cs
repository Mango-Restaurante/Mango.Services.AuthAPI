using Mango.Services.AuthAPI.Models;

namespace Mango.Services.AuthAPI.Service.IService
{
	public interface IJwtTokenGenerator
	{
		public string GenerateToken(AplicationUser aplicationUser);
	}
}
