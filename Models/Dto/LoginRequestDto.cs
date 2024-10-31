namespace Mango.Services.AuthAPI.Models.Dto
{
	public class LoginRequestDto
	{
		public string UserName { get; set; }
		public string Password { get; set; } //devuelve un USerDto + Token (LoginResponseDto)

	}
}
