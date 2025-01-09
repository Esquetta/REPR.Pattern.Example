using REPR.Pattern.Example.Manuel_Implementation.Minimal_API_Based.Features.Users.Commands.CreateUserCommand;
using REPR.Pattern.Example.Manuel_Implementation.Minimal_API_Based.Features.Users.Commands.UpdateUserJobCommand;

namespace REPR.Pattern.Example.Manuel_Implementation.Minimal_API_Based.Features.Users.Commands
{
    public static class UserEndPoint
    {
        public static void  RegisterUserEndPoints(this WebApplication application)
        {
            application.MapGroup("api2/users")
                .UpdateUserJobEndPoint()
                .CreateUserEndPoint();
        }
    }
}
