namespace Courses.API.Instructors.GetInstructor;

public record GetInstructorResponse(IEnumerable<Instructor> Instructors);

public class GetInstructorEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/instructors", async (ISender sender) =>
        {
            var result = await sender.Send(new GetInstructorsQuery());
            var response = result.Adapt<GetInstructorResponse>();

            return Results.Ok(response);
        })
        .WithName("Get Instructors")
        .WithSummary("Gets all instructors")
        .WithDescription("Gets all instructors")
        .Produces<CreateInstructorResponse>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status400BadRequest);
    }
}
