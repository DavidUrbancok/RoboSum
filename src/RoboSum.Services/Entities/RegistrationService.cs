namespace RoboSum.Services.Entities;

using AutoMapper;
using RoboSum.Domain.Entities;
using RoboSum.Domain.Repositories.Entities;
using RoboSum.DTOs;
using RoboSum.Services.Abstractions.Entities;

/// <summary>
/// Represents a service for <see cref="RegistrationDto"/> type.
/// </summary>
public class RegistrationService : AbstractService<IRegistrationRepository, Registration, RegistrationDto>, IRegistrationService
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RegistrationService"/> class.
    /// </summary>
    /// <param name="repository">The repository instance.</param>
    /// <param name="mapper">The DTO to entity mapper instance.</param>
    public RegistrationService(IRegistrationRepository repository, IMapper mapper)
        : base(repository, mapper)
    {
    }
}
