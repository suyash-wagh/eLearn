namespace Courses.API.Instructors.GetInstructor;

public record GetInstructorsByIdQuery(Guid Id) : IQuery<GetInstructorByIdResult>;
public record GetInstructorByIdResult(Instructor Instructor);

public class GetInstructorByIdQueryHandler(IDocumentSession session, ILogger<GetInstructorByIdQueryHandler> logger) : IQueryHandler<GetInstructorsByIdQuery, GetInstructorByIdResult>
{
    public async Task<GetInstructorByIdResult> Handle(GetInstructorsByIdQuery query, CancellationToken cancellationToken)
    {
        logger.LogInformation("Get all instructors called...");

        var instructor = await session.LoadAsync<Instructor>(query.Id, cancellationToken);

        return new GetInstructorByIdResult(instructor);
    }
}
