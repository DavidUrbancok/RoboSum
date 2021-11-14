namespace RoboSum.Services.Entities;

using AutoMapper;
using RoboSum.Domain.Entities;
using RoboSum.Domain.Repositories.Entities;
using RoboSum.DTOs;
using RoboSum.Services;
using RoboSum.Services.Abstractions.Entities;

/// <summary>
/// Represents a service for <see cref="AddressDto"/> type.
/// </summary>
public class AddressService : AbstractService<IAddressRepository, Address, AddressDto>, IAddressService
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AddressService"/> class.
    /// </summary>
    /// <param name="repository">The repository instance.</param>
    /// <param name="mapper">The DTO to entity mapper instance.</param>
    public AddressService(IAddressRepository repository, IMapper mapper)
        : base(repository, mapper)
    {
    }
}
