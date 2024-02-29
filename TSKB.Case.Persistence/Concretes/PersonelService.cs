using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSKB.Case.Application.Abstractions;
using TSKB.Case.Application.Dtos.Personel;
using TSKB.Case.Application.Repositories;
using TSKB.Case.Domain.Entities;
using TSKB.Case.Persistence.Concretes.Base;

namespace TSKB.Case.Persistence.Concretes
{
    public class PersonelService : BaseApplicationService<Personel, PersonelDto, PersonelCreateDto, PersonelUpdateDto>, IPersonelService
    {
        public PersonelService(IRepository<Personel> repository, IMapper mapper, IConfiguration configuration) : base(repository, mapper)
        {
        }
        public async Task IsEmailUniqueAsync(string email)
        {

            bool exists = await _repository.GetQueryable().AnyAsync(x => x.MailAdresi == email);
            if (exists)
            {
                throw new Exception($"{email}\nThis email address is already on use.");
            }
        }

        public async Task IsPersonalPhoneNumberUniqueAsync(string personalPhoneNumber)
        {
            bool exists = await _repository.GetQueryable().AnyAsync(x => x.CepTelefonu == personalPhoneNumber);
            if (exists)
            {
                throw new Exception($"{personalPhoneNumber}\nThis personal phone number is already on use.");
            }
        }

        public async Task IsHomePhoneNumberUniqueAsync(string homePhoneNumber)
        {
            bool exists = await _repository.GetQueryable().AnyAsync(x => x.EvTelefonu == homePhoneNumber);
            if (exists)
            {
                throw new Exception($"{homePhoneNumber}\nThis home phone number is already on use.");
            }
        }

        public virtual async Task<IEnumerable<Personel>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<Personel>>(entities);
        }

        public override async Task<PersonelDto> AddAsync(PersonelCreateDto dto)
        {
            await IsEmailUniqueAsync(dto.MailAdresi);
            await IsHomePhoneNumberUniqueAsync(dto.EvTelefonu);
            await IsPersonalPhoneNumberUniqueAsync(dto.CepTelefonu);
            return await base.AddAsync(dto);
        }
        public override async Task UpdateAsync(PersonelUpdateDto dto)
        {
            var entity = await _repository.GetByIdAsync(dto.Id);
            var mappedEntity = _mapper.Map<Personel>(dto);
            entity = mappedEntity;
            await _repository.UpdateAsync(entity);

        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await _repository.GetByIdAsync(id);
            await _repository.DeleteAsync(entity);
        }
    }
}
