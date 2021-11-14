namespace RoboSum.Services;

using RoboSum.DTOs;
using RoboSum.Services.Abstractions;
using RoboSum.Services.Abstractions.Entities;

/// <summary>
/// Represents a service for <see cref="RefereeDto"/> type.
/// </summary>
public class RefereeService : IRefereeService
{
    /// <inheritdoc cref="IService{RefereeDto}.GetAsync(int)"/>
    public Task<RefereeDto> GetAsync(int id)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc cref="IService{RefereeDto}.GetAll()"/>
    public IQueryable<RefereeDto> GetAll()
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc cref="IService{RefereeDto}.AddAsync(RefereeDto)"/>
    public Task AddAsync(RefereeDto entity)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc cref="IService{RefereeDto}.UpdateAsync(RefereeDto)"/>
    public Task UpdateAsync(RefereeDto entity)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc cref="IService{RefereeDto}.DeleteAsync(RefereeDto)"/>
    public Task DeleteAsync(RefereeDto entity)
    {
        throw new NotImplementedException();
    }
}
