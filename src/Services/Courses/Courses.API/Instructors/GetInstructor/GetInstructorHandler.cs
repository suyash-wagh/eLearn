
namespace Courses.API.Instructors.GetInstructor;

public record GetInstructorsQuery() : IQuery<GetInstructorsResult>;
public record GetInstructorsResult(IEnumerable<Instructor> Instructors);

public class GetInstructorQueryHandler(IDocumentSession session, ILogger<GetInstructorQueryHandler> logger) : IQueryHandler<GetInstructorsQuery, GetInstructorsResult>
{
    public async Task<GetInstructorsResult> Handle(GetInstructorsQuery query, CancellationToken cancellationToken)
    {
        logger.LogInformation("Get all instructors called...");

        var instructors = await session.Query<Instructor>().ToListAsync(cancellationToken);

        return new GetInstructorsResult(instructors);
    }
}
