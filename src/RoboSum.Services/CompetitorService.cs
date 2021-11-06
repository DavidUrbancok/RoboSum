namespace RoboSum.Services
{
    using System.Linq.Expressions;
    using RoboSum.DTOs;
    using RoboSum.Services.Abstractions;
    using RoboSum.Services.Abstractions.Entities;

    /// <summary>
    /// Represents a service for <see cref="CompetitorDto"/> type.
    /// </summary>
    public class CompetitorService : ICompetitorService
    {
        /// <inheritdoc cref="IService{CompetitorDto}.AddAsync(CompetitorDto)"/>
        public Task AddAsync(CompetitorDto entity)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IService{CompetitorDto}.DeleteAsync(CompetitorDto)"/>
        public Task DeleteAsync(CompetitorDto entity)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IService{CompetitorDto}.GetAllAsync"/>
        public Task<IQueryable<CompetitorDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IService{CompetitorDto}.GetAsync(int)"/>
        public Task<CompetitorDto> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IService{CompetitorDto}.GetByConditionAsync(Expression{Func{CompetitorDto, bool}})"/>
        public Task<IQueryable<CompetitorDto>> GetByConditionAsync(Expression<Func<CompetitorDto, bool>> condition)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IService{CompetitorDto}.UpdateAsync(CompetitorDto)"/>
        public Task UpdateAsync(CompetitorDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
