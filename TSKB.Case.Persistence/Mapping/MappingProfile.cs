using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSKB.Case.Application.Dtos.Departman;
using TSKB.Case.Application.Dtos.Personel;
using TSKB.Case.Domain.Entities;

namespace TSKB.Case.Persistence.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Personel, PersonelDto>();
            CreateMap<PersonelCreateDto, Personel>();
            CreateMap<PersonelUpdateDto, Personel>();

            CreateMap<Departman, DepartmanDto>();
            CreateMap<DepartmanCreateDto, Departman>();
            CreateMap<DepartmanUpdateDto, Departman>();
        }
    }
}
