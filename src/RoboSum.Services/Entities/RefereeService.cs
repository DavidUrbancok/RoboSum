namespace RoboSum.Services.Entities;

using AutoMapper;
using RoboSum.Domain.Entities;
using RoboSum.Domain.Repositories.Entities;
using RoboSum.DTOs;
using RoboSum.Services.Abstractions.Entities;

/// <summary>
/// Represents a service for <see cref="RefereeDto"/> type.
/// </summary>
public class RefereeService : AbstractService<IRefereeRepository, Referee, RefereeDto>, IRefereeService
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RefereeService"/> class.
    /// </summary>
    /// <param name="repository">The repository instance.</param>
    /// <param name="mapper">The DTO to entity mapper instance.</param>
    public RefereeService(IRefereeRepository repository, IMapper mapper)
        : base(repository, mapper)
    {
    }
}
