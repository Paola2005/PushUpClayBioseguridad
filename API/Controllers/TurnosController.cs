using API.Dtos;
using API.Helpers;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    public class TurnosController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TurnosController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<TurnosDto>>> Get11()
        {
            var Turnoss = await _unitOfWork.Turnoss.GetAllAsync();
            return _mapper.Map<List<TurnosDto>>(Turnoss);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TurnosDto>> Get(int id)
        {
            var Turnos = await _unitOfWork.Turnoss.GetByIdAsync(id);
            if (Turnos == null)
                return NotFound(new ApiResponse(404, $"El Turnos solicitado no existe."));

            return _mapper.Map<TurnosDto>(Turnos);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Turnos>> Post(TurnosDto TurnosDto)
        {
            var Turnos = _mapper.Map<Turnos>(TurnosDto);
            _unitOfWork.Turnoss.Add(Turnos);
            await _unitOfWork.SaveAsync();
            if (Turnos == null)
                return BadRequest(new ApiResponse(400));

            TurnosDto.Id = Turnos.Id;
            return CreatedAtAction(nameof(Post), new { id = TurnosDto.Id }, TurnosDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<TurnosDto>> Put(int id, [FromBody] TurnosDto TurnosDto)
        {
            if (TurnosDto == null)
                return NotFound(new ApiResponse(404, $"El Turnos solicitado no existe."));

            var TurnosBd = await _unitOfWork.Turnoss.GetByIdAsync(id);
            if (TurnosBd == null)
                return NotFound(new ApiResponse(404, $"El Turnos solicitado no existe."));

            var Turnos = _mapper.Map<Turnos>(TurnosDto);
            _unitOfWork.Turnoss.Update(Turnos);
            await _unitOfWork.SaveAsync();
            return TurnosDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var Turnos = await _unitOfWork.Turnoss.GetByIdAsync(id);
            if (Turnos == null)
                return NotFound(new ApiResponse(404, $"El Turnos solicitado no existe."));

            _unitOfWork.Turnoss.Remove(Turnos);
            await _unitOfWork.SaveAsync();

            return NoContent();
        }
    }
}