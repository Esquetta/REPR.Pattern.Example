using FastEndpoints;

namespace REPR.Pattern.Example.FastEndpoints_Implementation.Featues.Users.CreateUser
{
    public class CreateUserEndPoint : Endpoint<CreateUserRequest, CreateUserResponse>
    {
        public override void Configure()
        {
            Post("/api3/users/create");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CreateUserRequest req, CancellationToken ct)
        {
            var response = new CreateUserResponse(1, "Furkan", "Tasci", 23);

            await SendAsync(response);
        }
    }
}
