namespace RoboSum.Services;

using RoboSum.DTOs;
using RoboSum.Services.Abstractions;
using RoboSum.Services.Abstractions.Entities;

/// <summary>
/// Represents a service for <see cref="RegistrationDto"/> type.
/// </summary>
public class RegistrationService : IRegistrationService
{
    /// <inheritdoc cref="IService{RegistrationDto}.GetAsync(int)"/>
    public Task<RegistrationDto> GetAsync(int id)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc cref="IService{RegistrationDto}.GetAll()"/>
    public IQueryable<RegistrationDto> GetAll()
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc cref="IService{RegistrationDto}.AddAsync(RegistrationDto)"/>
    public Task AddAsync(RegistrationDto entity)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc cref="IService{RegistrationDto}.UpdateAsync(RegistrationDto)"/>
    public Task UpdateAsync(RegistrationDto entity)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc cref="IService{RegistrationDto}.DeleteAsync(RegistrationDto)"/>
    public Task DeleteAsync(RegistrationDto entity)
    {
        throw new NotImplementedException();
    }
}
