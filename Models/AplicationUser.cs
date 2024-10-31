using Microsoft.AspNetCore.Identity;

namespace Mango.Services.AuthAPI.Models
{
	public class AplicationUser : IdentityUser
	{
        public string Name { get; set; }
    }
}
