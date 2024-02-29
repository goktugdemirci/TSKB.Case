using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSKB.Case.Application.Dtos.Common;

namespace TSKB.Case.Application.Abstractions.Base
{
    public interface IBaseApplicationService<TDto, TCreateDto, TUpdateDto>
            where TDto : BaseEntityDto
            where TCreateDto : class
            where TUpdateDto : BaseEntityDto
    {
        Task<IEnumerable<TDto>> GetAllAsync();
        Task<TDto> GetByIdAsync(Guid id);
        Task<TDto> AddAsync(TCreateDto dto);
        Task UpdateAsync(TUpdateDto dto);
        Task DeleteAsync(TDto dto);
        Task DeleteAsync(Guid id);
    }
}
