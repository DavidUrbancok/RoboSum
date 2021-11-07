namespace RoboSum.Services
{
    using AutoMapper;
    using RoboSum.Domain.Entities;
    using RoboSum.Domain.Repositories.Entities;
    using RoboSum.DTOs;
    using RoboSum.Services.Abstractions;
    using RoboSum.Services.Abstractions.Entities;

    /// <summary>
    /// Represents a service for <see cref="AddressDto"/> type.
    /// </summary>
    public class AddressService : IAddressService
    {
        private readonly IMapper _mapper;
        private readonly IAddressRepository _addressRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressService"/> class.
        /// </summary>
        /// <param name="addressRepository">The address repository instance.</param>
        /// <param name="mapper">The DTO to entity mapper instance.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown, when <paramref name="addressRepository"/> or <paramref name="mapper"/> is <see langword="null"/>.
        /// </exception>
        public AddressService(IAddressRepository addressRepository, IMapper mapper)
        {
            _addressRepository = addressRepository ?? throw new ArgumentNullException(nameof(addressRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <inheritdoc cref="IService{AddressDto}.GetAsync(int)"/>
        public async Task<AddressDto> GetAsync(int id)
        {
            Address address = await _addressRepository.GetAsync(id);

            return _mapper.Map<AddressDto>(address);
        }

        /// <inheritdoc cref="IService{AddressDto}.GetAll()"/>
        public IQueryable<AddressDto> GetAll()
        {
            IQueryable<Address> addresses = _addressRepository.GetAll();

            return _mapper.Map<IQueryable<AddressDto>>(addresses);
        }

        /// <inheritdoc cref="IService{AddressDto}.AddAsync(AddressDto)"/>
        public async Task AddAsync(AddressDto entity)
        {
            Address address = _mapper.Map<Address>(entity);

            await _addressRepository.AddAsync(address);
        }

        /// <inheritdoc cref="IService{AddressDto}.UpdateAsync(AddressDto)"/>
        public async Task UpdateAsync(AddressDto entity)
        {
            Address address = _mapper.Map<Address>(entity);

            await _addressRepository.UpdateAsync(address);
        }

        /// <inheritdoc cref="IService{AddressDto}.DeleteAsync(AddressDto)"/>
        public async Task DeleteAsync(AddressDto entity)
        {
            Address address = _mapper.Map<Address>(entity);

            await _addressRepository.DeleteAsync(address);
        }
    }
}
