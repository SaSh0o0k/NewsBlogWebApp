using Blog.Web.Data.Entities.Identity;

namespace Blog.Web.Interfaces
{
    public interface IJwtTokenService
    {
        Task<string> CreateTokenAsync(UserEntity user);
    }
}
