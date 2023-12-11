using API.Dtos;
using API.Helpers;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    public class TipoContactosController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TipoContactosController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<TipoContactosDto>>> Get11()
        {
            var TipoContactoss = await _unitOfWork.TiposContactos.GetAllAsync();
            return _mapper.Map<List<TipoContactosDto>>(TipoContactoss);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TipoContactosDto>> Get(int id)
        {
            var TipoContactos = await _unitOfWork.TiposContactos.GetByIdAsync(id);
            if (TipoContactos == null)
                return NotFound(new ApiResponse(404, $"El TipoContactos solicitado no existe."));

            return _mapper.Map<TipoContactosDto>(TipoContactos);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<TipoContactos>> Post(TipoContactosDto TipoContactosDto)
        {
            var TipoContactos = _mapper.Map<TipoContactos>(TipoContactosDto);
            _unitOfWork.TiposContactos.Add(TipoContactos);
            await _unitOfWork.SaveAsync();
            if (TipoContactos == null)
                return BadRequest(new ApiResponse(400));

            TipoContactosDto.Id = TipoContactos.Id;
            return CreatedAtAction(nameof(Post), new { id = TipoContactosDto.Id }, TipoContactosDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<TipoContactosDto>> Put(int id, [FromBody] TipoContactosDto TipoContactosDto)
        {
            if (TipoContactosDto == null)
                return NotFound(new ApiResponse(404, $"El TipoContactos solicitado no existe."));

            var TipoContactosBd = await _unitOfWork.TiposContactos.GetByIdAsync(id);
            if (TipoContactosBd == null)
                return NotFound(new ApiResponse(404, $"El TipoContactos solicitado no existe."));

            var TipoContactos = _mapper.Map<TipoContactos>(TipoContactosDto);
            _unitOfWork.TiposContactos.Update(TipoContactos);
            await _unitOfWork.SaveAsync();
            return TipoContactosDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var TipoContactos = await _unitOfWork.TiposContactos.GetByIdAsync(id);
            if (TipoContactos == null)
                return NotFound(new ApiResponse(404, $"El TipoContactos solicitado no existe."));

            _unitOfWork.TiposContactos.Remove(TipoContactos);
            await _unitOfWork.SaveAsync();

            return NoContent();
        }
    }
}