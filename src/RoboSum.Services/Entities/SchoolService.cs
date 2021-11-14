namespace RoboSum.Services.Entities;

using AutoMapper;
using RoboSum.Domain.Entities;
using RoboSum.Domain.Repositories.Entities;
using RoboSum.DTOs;
using RoboSum.Services.Abstractions.Entities;

/// <summary>
/// Represents a service for <see cref="SchoolDto"/> type.
/// </summary>
public class SchoolService : AbstractService<ISchoolRepository, School, SchoolDto>, ISchoolService
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SchoolService"/> class.
    /// </summary>
    /// <param name="repository">The repository instance.</param>
    /// <param name="mapper">The DTO to entity mapper instance.</param>
    public SchoolService(ISchoolRepository repository, IMapper mapper)
        : base(repository, mapper)
    {
    }
}
