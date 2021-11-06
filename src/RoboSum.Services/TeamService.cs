namespace RoboSum.Services
{
    using System.Linq.Expressions;
    using RoboSum.DTOs;
    using RoboSum.Services.Abstractions;
    using RoboSum.Services.Abstractions.Entities;

    /// <summary>
    /// Represents a service for <see cref="TeamDto"/> type.
    /// </summary>
    public class TeamService : ITeamService
    {
        /// <inheritdoc cref="IService{TeamDto}.AddAsync(TeamDto)"/>
        public Task AddAsync(TeamDto entity)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IService{TeamDto}.DeleteAsync(TeamDto)"/>
        public Task DeleteAsync(TeamDto entity)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IService{TeamDto}.GetAllAsync()"/>
        public Task<IQueryable<TeamDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IService{TeamDto}.GetAsync(int)"/>
        public Task<TeamDto> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IService{TeamDto}.GetByConditionAsync(Expression{Func{TeamDto, bool}})"/>
        public Task<IQueryable<TeamDto>> GetByConditionAsync(Expression<Func<TeamDto, bool>> condition)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IService{TeamDto}.UpdateAsync(TeamDto)"/>
        public Task UpdateAsync(TeamDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
