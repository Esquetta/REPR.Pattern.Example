using REPR.Pattern.Example.Manuel_Implementation.Minimal_API_Based.Features.Users.Commands;

namespace REPR.Pattern.Example.Manuel_Implementation.Minimal_API_Based.EndPoints
{
    public static class RegisterRequestMapping
    {
        public static void RegisterMappings(this WebApplication webApplication)
        {
            UserEndPoints.RegisterUserEndPoints(webApplication);
        }
    }
}
