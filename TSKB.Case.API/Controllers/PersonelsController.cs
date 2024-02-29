using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TSKB.Case.Application.Abstractions;
using TSKB.Case.Application.Dtos.Personel;

namespace TSKB.Case.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonelsController : ControllerBase
    {
        private readonly IPersonelService _personelService;

        public PersonelsController(IPersonelService personelService)
        {
            _personelService = personelService;
        }

        [HttpGet("GetAllAsync")]
        public async Task<IEnumerable<PersonelDto>> GetAllAsync()
        {
            return await _personelService.GetAllAsync();
        }

        [HttpGet("GetByIdAsync")]
        public async Task<PersonelDto> GetByIdAsync(Guid id)
        {
            return await _personelService.GetByIdAsync(id);
        }

        [HttpPost("CreateAsync")]
        public async Task<PersonelDto> CreateAsync(PersonelCreateDto dto)
        {
            return await _personelService.AddAsync(dto);
        }

        [HttpPut("UpdateAsync")]
        public async Task<IActionResult> UpdateAsync(PersonelUpdateDto dto)
        {
            await _personelService.UpdateAsync(dto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
             await _personelService.DeleteAsync(id);
            return Ok();
        }
    }
}
