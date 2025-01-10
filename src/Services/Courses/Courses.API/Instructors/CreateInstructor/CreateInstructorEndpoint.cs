using Courses.API.Models;

namespace Courses.API.Instructors.CreateInstructor;

public record CreateInstructorRequest(string Name, List<Course> Courses, string About, string Description, decimal Rating, string Picture);
public record CreateInstructorResponse(Guid Id);

public class CreateInstructorEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("/instructors", async (CreateInstructorRequest request, ISender sender) =>
        {
            var command = request.Adapt<CreateInstructorCommand>();
            var result = await sender.Send(command);
            var response = result.Adapt<CreateInstructorResponse>();
            return Results.Created($"/instructors/{response.Id}", response);
        })
        .WithName("Create Instructor")
        .WithSummary("Adds an instructor")
        .WithDescription("Adds an instructor")
        .Produces<CreateInstructorResponse>(StatusCodes.Status201Created)
        .ProducesProblem(StatusCodes.Status400BadRequest);
    }
}