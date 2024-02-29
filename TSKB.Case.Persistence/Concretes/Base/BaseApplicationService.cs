using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSKB.Case.Application.Abstractions.Base;
using TSKB.Case.Application.Dtos.Common;
using TSKB.Case.Application.Repositories;
using TSKB.Case.Domain.Entities.Common;

namespace TSKB.Case.Persistence.Concretes.Base
{
    public class BaseApplicationService<TEntity, TDto, TCreateDto, TUpdateDto> : IBaseApplicationService<TDto, TCreateDto, TUpdateDto>
        where TEntity : BaseEntity
        where TDto : BaseEntityDto
        where TCreateDto : class
        where TUpdateDto : BaseEntityDto
    {
        protected readonly IRepository<TEntity> _repository;
        protected readonly IMapper _mapper;

        public BaseApplicationService(IRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public virtual async Task<IEnumerable<TDto>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<TDto>>(entities);
        }

        public virtual async Task<TDto> GetByIdAsync(Guid id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return _mapper.Map<TDto>(entity);
        }

        public virtual async Task<TDto> AddAsync(TCreateDto dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto));
            }

            var entity = _mapper.Map<TEntity>(dto);
            entity = await _repository.AddAsync(entity);

            return _mapper.Map<TDto>(entity);
        }

        public virtual async Task UpdateAsync(TUpdateDto dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto));
            }

            var entity = _mapper.Map<TEntity>(dto);
            await _repository.UpdateAsync(entity);
        }

        public virtual async Task DeleteAsync(TDto dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto));
            }

            var entity = _mapper.Map<TEntity>(dto);
            await _repository.DeleteAsync(entity);
        }

        public virtual async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
