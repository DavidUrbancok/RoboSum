namespace RoboSum.Services.Entities;

using AutoMapper;
using RoboSum.Domain.Entities;
using RoboSum.Domain.Repositories.Entities;
using RoboSum.DTOs;
using RoboSum.Services.Abstractions.Entities;

/// <summary>
/// Represents a service for <see cref="TeamDto"/> type.
/// </summary>
public class TeamService : AbstractService<ITeamRepository, Team, TeamDto>, ITeamService
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TeamService"/> class.
    /// </summary>
    /// <param name="repository">The repository instance.</param>
    /// <param name="mapper">The DTO to entity mapper instance.</param>
    public TeamService(ITeamRepository repository, IMapper mapper)
        : base(repository, mapper)
    {
    }
}
