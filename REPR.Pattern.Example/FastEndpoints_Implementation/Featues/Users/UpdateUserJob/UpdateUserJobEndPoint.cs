using FastEndpoints;

namespace REPR.Pattern.Example.FastEndpoints_Implementation.Featues.Users.UpdateUserJob
{
    public class UpdateUserJobEndPoint : Endpoint<UpdateUserJobRequest, UpdateUserJobResponse>
    {
        public override void Configure()
        {
            Put("api/user/update-job");
            AllowAnonymous();
        }
        public override async Task HandleAsync(UpdateUserJobRequest req, CancellationToken ct)
        {
            var resnpose = new UpdateUserJobResponse(req.UserId, "Job information has been successfully updated...");
            await SendAsync(Response);
        }
    }
}
