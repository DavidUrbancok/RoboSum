namespace RoboSum.Services;

using AutoMapper;
using RoboSum.Domain.Repositories;
using RoboSum.Services.Abstractions;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Represents a base service for all entities. This is an <see langword="abstract"/> class.
/// </summary>
/// <typeparam name="TRepository">The type of the underlying repository.</typeparam>
/// <typeparam name="TClass">The type of the class in the repository.</typeparam>
/// <typeparam name="TDto">The type of the DTO class.</typeparam>
public abstract class AbstractService<TRepository, TClass, TDto> : IService<TDto>
    where TRepository : IRepository<TClass>
    where TDto : class
    where TClass : class
{
    private readonly IMapper _mapper;
    private readonly IRepository<TClass> _repository;

    /// <summary>
    /// Initializes a new instance of the <see cref="AbstractService{TRepository, TClass, TDto}"/> class.
    /// </summary>
    /// <param name="repository">The repository that interacts with the persistance layer.</param>
    /// <param name="mapper">The DTO to entity mapper instance.</param>
    protected AbstractService(TRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    /// <inheritdoc cref="IService{TDto}.GetAsync(int)"/>
    public async Task<TDto> GetAsync(int id)
    {
        TClass @class = await _repository.GetByIdAsync(id);

        return _mapper.Map<TDto>(@class);
    }

    /// <inheritdoc cref="IService{TDto}.GetAll()"/>
    public IQueryable<TDto> GetAll()
    {
        IQueryable<TClass> classes = _repository.GetAll();

        return _mapper.Map<IQueryable<TDto>>(classes);
    }

    /// <inheritdoc cref="IService{TDto}.AddAsync(TDto)"/>
    public async Task AddAsync(TDto entity)
    {
        TClass @class = _mapper.Map<TClass>(entity);

        await _repository.UpdateAsync(@class);
    }

    /// <inheritdoc cref="IService{TDto}.UpdateAsync(TDto)"/>
    public async Task UpdateAsync(TDto entity)
    {
        TClass @class = _mapper.Map<TClass>(entity);

        await _repository.UpdateAsync(@class);
    }

    /// <inheritdoc cref="IService{TDto}.DeleteAsync(TDto)"/>
    public async Task DeleteAsync(TDto entity)
    {
        TClass @class = _mapper.Map<TClass>(entity);

        await _repository.RemoveAsync(@class);
    }
}
