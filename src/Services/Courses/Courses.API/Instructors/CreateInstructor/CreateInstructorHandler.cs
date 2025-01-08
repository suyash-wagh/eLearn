using Courses.API.Models;
using Infrastructure.Base.CQRS;
using MediatR;

namespace Courses.API.Instructors.CreateInstructor
{
    public record CreateInstructorCommand(string Name, List<Course> Courses, string About, string Description, decimal Rating, string Picture) 
        : ICommand<CreateInstructorResult>;
    public record CreateInstructorResult(Guid Id);

    internal class CreateInstructorCommandHandler : ICommandHandler<CreateInstructorCommand, CreateInstructorResult>
    {
        public Task<CreateInstructorResult> Handle(CreateInstructorCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
