using Mediator;

namespace REPR.Pattern.Example.Manuel_Implementation.Minimal_API_Based.Features.Users.Commands.CreateUserCommand
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        public ValueTask<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            //Process...

            var response = new CreateUserCommandResponse()
            {
                UserId = 0,
                Message = $"The user has been successfully created... | {request.Name}, {request.Surname}, {request.Age}"
            };

            return ValueTask.FromResult(response);
        }
    }
}
