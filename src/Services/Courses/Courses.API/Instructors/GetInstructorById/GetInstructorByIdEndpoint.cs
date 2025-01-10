namespace Courses.API.Instructors.GetInstructor;

public record GetInstructorByIdResponse(Instructor Instructor);

public class GetInstructorByIdEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/instructors/{Id}", async (ISender sender, Guid Id) =>
        {
            var result = await sender.Send(new GetInstructorsByIdQuery(Id));
            var response = result.Adapt<GetInstructorByIdResponse>();

            return Results.Ok(response);
        })
        .WithName("Get Instructor By Id")
        .WithSummary("Gets instructor by id")
        .WithDescription("Gets instructor by id")
        .Produces<GetInstructorByIdResponse>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status400BadRequest);
    }
}
