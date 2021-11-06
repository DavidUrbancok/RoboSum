namespace RoboSum.Services
{
    using System.Linq.Expressions;
    using RoboSum.DTOs;
    using RoboSum.Services.Abstractions;
    using RoboSum.Services.Abstractions.Entities;

    /// <summary>
    /// Represents a service for <see cref="AddressDto"/> type.
    /// </summary>
    public class AddressService : IAddressService
    {
        /// <inheritdoc cref="IService{AddressDto}.AddAsync(AddressDto)"/>
        public Task AddAsync(AddressDto entity)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IService{AddressDto}.DeleteAsync(AddressDto)"/>
        public Task DeleteAsync(AddressDto entity)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IService{AddressDto}.GetAllAsync()"/>
        public Task<IQueryable<AddressDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IService{AddressDto}.GetAsync(int)"/>
        public Task<AddressDto> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IService{AddressDto}.GetByConditionAsync(Expression{Func{AddressDto, bool}})"/>
        public Task<IQueryable<AddressDto>> GetByConditionAsync(Expression<Func<AddressDto, bool>> condition)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IService{AddressDto}.UpdateAsync(AddressDto)"/>
        public Task UpdateAsync(AddressDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
