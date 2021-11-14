namespace RoboSum.Services.Entities;

using AutoMapper;
using RoboSum.Domain.Entities;
using RoboSum.Domain.Repositories.Entities;
using RoboSum.DTOs;
using RoboSum.Services.Abstractions.Entities;

/// <summary>
/// Represents a service for <see cref="TeacherDto"/> type.
/// </summary>
public class TeacherService : AbstractService<ITeacherRepository, Teacher, TeacherDto>, ITeacherService
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TeacherService"/> class.
    /// </summary>
    /// <param name="repository">The repository instance.</param>
    /// <param name="mapper">The DTO to entity mapper instance.</param>
    public TeacherService(ITeacherRepository repository, IMapper mapper)
        : base(repository, mapper)
    {
    }
}
