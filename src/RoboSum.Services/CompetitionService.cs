﻿namespace RoboSum.Services
{
    using RoboSum.DTOs;
    using RoboSum.Services.Abstractions;
    using RoboSum.Services.Abstractions.Entities;

    /// <summary>
    /// Represents a service for <see cref="CompetitionDto"/> type.
    /// </summary>
    public class CompetitionService : ICompetitionService
    {
        /// <inheritdoc cref="IService{CompetitionDto}.GetAsync(int)"/>
        public Task<CompetitionDto> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IService{CompetitionDto}.GetAll()"/>
        public IQueryable<CompetitionDto> GetAll()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IService{CompetitionDto}.AddAsync(CompetitionDto)"/>
        public Task AddAsync(CompetitionDto entity)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IService{CompetitionDto}.UpdateAsync(CompetitionDto)"/>
        public Task UpdateAsync(CompetitionDto entity)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IService{CompetitionDto}.DeleteAsync(CompetitionDto)"/>
        public Task DeleteAsync(CompetitionDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
