using API.Dtos;
using API.Helpers;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    public class ContactoPersonaController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ContactoPersonaController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<ContactoPersonaDto>>> Get11()
        {
            var ContactoPersonas = await _unitOfWork.ContactoPersonas.GetAllAsync();
            return _mapper.Map<List<ContactoPersonaDto>>(ContactoPersonas);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ContactoPersonaDto>> Get(int id)
        {
            var ContactoPersona = await _unitOfWork.ContactoPersonas.GetByIdAsync(id);
            if (ContactoPersona == null)
                return NotFound(new ApiResponse(404, $"El ContactoPersona solicitado no existe."));

            return _mapper.Map<ContactoPersonaDto>(ContactoPersona);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ContactoPersona>> Post(ContactoPersonaDto ContactoPersonaDto)
        {
            var ContactoPersona = _mapper.Map<ContactoPersona>(ContactoPersonaDto);
            _unitOfWork.ContactoPersonas.Add(ContactoPersona);
            await _unitOfWork.SaveAsync();
            if (ContactoPersona == null)
                return BadRequest(new ApiResponse(400));

            ContactoPersonaDto.Id = ContactoPersona.Id;
            return CreatedAtAction(nameof(Post), new { id = ContactoPersonaDto.Id }, ContactoPersonaDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ContactoPersonaDto>> Put(int id, [FromBody] ContactoPersonaDto ContactoPersonaDto)
        {
            if (ContactoPersonaDto == null)
                return NotFound(new ApiResponse(404, $"El ContactoPersona solicitado no existe."));

            var ContactoPersonaBd = await _unitOfWork.ContactoPersonas.GetByIdAsync(id);
            if (ContactoPersonaBd == null)
                return NotFound(new ApiResponse(404, $"El ContactoPersona solicitado no existe."));

            var ContactoPersona = _mapper.Map<ContactoPersona>(ContactoPersonaDto);
            _unitOfWork.ContactoPersonas.Update(ContactoPersona);
            await _unitOfWork.SaveAsync();
            return ContactoPersonaDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var ContactoPersona = await _unitOfWork.ContactoPersonas.GetByIdAsync(id);
            if (ContactoPersona == null)
                return NotFound(new ApiResponse(404, $"El ContactoPersona solicitado no existe."));

            _unitOfWork.ContactoPersonas.Remove(ContactoPersona);
            await _unitOfWork.SaveAsync();

            return NoContent();
        }
    }
}