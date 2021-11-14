namespace RoboSum.Services.Entities;

using AutoMapper;
using RoboSum.Domain.Entities;
using RoboSum.Domain.Repositories.Entities;
using RoboSum.DTOs;
using RoboSum.Services.Abstractions.Entities;

/// <summary>
/// Represents a service for <see cref="CompetitionDto"/> type.
/// </summary>
public class CompetitionService : AbstractService<ICompetitionRepository, Competition, CompetitionDto>, ICompetitionService
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CompetitionService"/> class.
    /// </summary>
    /// <param name="repository">The repository instance.</param>
    /// <param name="mapper">The DTO to entity mapper instance.</param>
    public CompetitionService(ICompetitionRepository repository, IMapper mapper)
        : base(repository, mapper)
    {
    }
}
