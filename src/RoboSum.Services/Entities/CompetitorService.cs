namespace RoboSum.Services.Entities;

using AutoMapper;
using RoboSum.Domain.Entities;
using RoboSum.Domain.Repositories.Entities;
using RoboSum.DTOs;
using RoboSum.Services.Abstractions.Entities;

/// <summary>
/// Represents a service for <see cref="CompetitorDto"/> type.
/// </summary>
public class CompetitorService : AbstractService<ICompetitorRepository, Competitor, CompetitorDto>, ICompetitorService
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CompetitorService"/> class.
    /// </summary>
    /// <param name="repository">The repository instance.</param>
    /// <param name="mapper">The DTO to entity mapper instance.</param>
    public CompetitorService(ICompetitorRepository repository, IMapper mapper)
        : base(repository, mapper)
    {
    }
}
