namespace RoboSum.Services;

using RoboSum.DTOs;
using RoboSum.Services.Abstractions;
using RoboSum.Services.Abstractions.Entities;

/// <summary>
/// Represents a service for <see cref="SchoolDto"/> type.
/// </summary>
public class SchoolService : ISchoolService
{
    /// <inheritdoc cref="IService{SchoolDto}.GetAsync(int)"/>
    public Task<SchoolDto> GetAsync(int id)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc cref="IService{SchoolDto}.GetAll()"/>
    public IQueryable<SchoolDto> GetAll()
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc cref="IService{SchoolDto}.AddAsync(SchoolDto)"/>
    public Task AddAsync(SchoolDto entity)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc cref="IService{SchoolDto}.UpdateAsync(SchoolDto)"/>
    public Task UpdateAsync(SchoolDto entity)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc cref="IService{SchoolDto}.DeleteAsync(SchoolDto)"/>
    public Task DeleteAsync(SchoolDto entity)
    {
        throw new NotImplementedException();
    }
}
