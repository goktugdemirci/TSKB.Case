using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSKB.Case.Application.Abstractions.Base;
using TSKB.Case.Application.Dtos.Personel;

namespace TSKB.Case.Application.Abstractions
{
    public interface IPersonelService : IBaseApplicationService<PersonelDto,PersonelCreateDto,PersonelUpdateDto>
    {
        Task IsPersonalPhoneNumberUniqueAsync(string personalPhoneNumber);
        Task IsHomePhoneNumberUniqueAsync(string personalPhoneNumber);
        Task IsEmailUniqueAsync(string personalPhoneNumber);
    }
}
