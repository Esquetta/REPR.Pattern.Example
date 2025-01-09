using Mediator;

namespace REPR.Pattern.Example.Manuel_Implementation.Minimal_API_Based.Features.Users.Commands.UpdateUserJobCommand
{
    public class UpdateUserJobCommandRequest : IRequest<UpdateUserJobCommandResponse>
    {
        public int UserId { get; set; }
        public string NewJob { get; set; }
    }
}
