using Mediator;

namespace REPR.Pattern.Example.Manuel_Implementation.Minimal_API_Based.Features.Users.Commands.UpdateUserJobCommand
{
    public class UpdateUserJobCommandHandler : IRequestHandler<UpdateUserJobCommandRequest, UpdateUserJobCommandResponse>
    {
        public ValueTask<UpdateUserJobCommandResponse> Handle(UpdateUserJobCommandRequest request, CancellationToken cancellationToken)
        {
            //Process...

            var response = new UpdateUserJobCommandResponse()
            {
                UserId = request.UserId,
                Message = "Job information has been successfully updated..."
            };

            return ValueTask.FromResult(response);
        }
    }
}
