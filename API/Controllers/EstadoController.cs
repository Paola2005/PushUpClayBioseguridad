using API.Dtos;
using API.Helpers;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    public class EstadoController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EstadoController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<EstadoDto>>> Get11()
        {
            var Estados = await _unitOfWork.Etados.GetAllAsync();
            return _mapper.Map<List<EstadoDto>>(Estados);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<EstadoDto>> Get(int id)
        {
            var Estado = await _unitOfWork.Etados.GetByIdAsync(id);
            if (Estado == null)
                return NotFound(new ApiResponse(404, $"El Estado solicitado no existe."));

            return _mapper.Map<EstadoDto>(Estado);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Estado>> Post(EstadoDto EstadoDto)
        {
            var Estado = _mapper.Map<Estado>(EstadoDto);
            _unitOfWork.Etados.Add(Estado);
            await _unitOfWork.SaveAsync();
            if (Estado == null)
                return BadRequest(new ApiResponse(400));

            EstadoDto.Id = Estado.Id;
            return CreatedAtAction(nameof(Post), new { id = EstadoDto.Id }, EstadoDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<EstadoDto>> Put(int id, [FromBody] EstadoDto EstadoDto)
        {
            if (EstadoDto == null)
                return NotFound(new ApiResponse(404, $"El Estado solicitado no existe."));

            var EstadoBd = await _unitOfWork.Etados.GetByIdAsync(id);
            if (EstadoBd == null)
                return NotFound(new ApiResponse(404, $"El Estado solicitado no existe."));

            var Estado = _mapper.Map<Estado>(EstadoDto);
            _unitOfWork.Etados.Update(Estado);
            await _unitOfWork.SaveAsync();
            return EstadoDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var Estado = await _unitOfWork.Etados.GetByIdAsync(id);
            if (Estado == null)
                return NotFound(new ApiResponse(404, $"El Estado solicitado no existe."));

            _unitOfWork.Etados.Remove(Estado);
            await _unitOfWork.SaveAsync();

            return NoContent();
        }
    }
}