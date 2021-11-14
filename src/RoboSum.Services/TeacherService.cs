namespace RoboSum.Services;

using RoboSum.DTOs;
using RoboSum.Services.Abstractions;
using RoboSum.Services.Abstractions.Entities;

/// <summary>
/// Represents a service for <see cref="TeacherDto"/> type.
/// </summary>
public class TeacherService : ITeacherService
{
    /// <inheritdoc cref="IService{TeacherDto}.GetAsync(int)"/>
    public Task<TeacherDto> GetAsync(int id)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc cref="IService{TeacherDto}.GetAll()"/>
    public IQueryable<TeacherDto> GetAll()
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc cref="IService{TeacherDto}.AddAsync(TeacherDto)"/>
    public Task AddAsync(TeacherDto entity)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc cref="IService{TeacherDto}.UpdateAsync(TeacherDto)"/>
    public Task UpdateAsync(TeacherDto entity)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc cref="IService{TeacherDto}.DeleteAsync(TeacherDto)"/>
    public Task DeleteAsync(TeacherDto entity)
    {
        throw new NotImplementedException();
    }
}
