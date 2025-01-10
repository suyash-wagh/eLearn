namespace Courses.API.Instructors.CreateInstructor;

public record CreateInstructorCommand(string Name, List<Course> Courses, string About, string Description, decimal Rating, string Picture) 
    : ICommand<CreateInstructorResult>;
public record CreateInstructorResult(Guid Id);

internal class CreateInstructorCommandHandler(IDocumentSession session) : ICommandHandler<CreateInstructorCommand, CreateInstructorResult>
{
    public async Task<CreateInstructorResult> Handle(CreateInstructorCommand request, CancellationToken cancellationToken)
    {
        var instructor = new Instructor()
        {
            Name = request.Name,
            About = request.About,
            Description = request.Description,
            Rating = request.Rating,
            Picture = request.Picture,
            Courses = request.Courses
        };

        session.Store(instructor);
        await session.SaveChangesAsync(cancellationToken);

        return new CreateInstructorResult(instructor.Id);
    }
}
