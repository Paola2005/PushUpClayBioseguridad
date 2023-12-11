using API.Dtos;
using API.Helpers;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    public class PaisController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PaisController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<PaisDto>>> Get11()
        {
            var Paiss = await _unitOfWork.Paises.GetAllAsync();
            return _mapper.Map<List<PaisDto>>(Paiss);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PaisDto>> Get(int id)
        {
            var Pais = await _unitOfWork.Paises.GetByIdAsync(id);
            if (Pais == null)
                return NotFound(new ApiResponse(404, $"El Pais solicitado no existe."));

            return _mapper.Map<PaisDto>(Pais);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Pais>> Post(PaisDto PaisDto)
        {
            var Pais = _mapper.Map<Pais>(PaisDto);
            _unitOfWork.Paises.Add(Pais);
            await _unitOfWork.SaveAsync();
            if (Pais == null)
                return BadRequest(new ApiResponse(400));

            PaisDto.Id = Pais.Id;
            return CreatedAtAction(nameof(Post), new { id = PaisDto.Id }, PaisDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<PaisDto>> Put(int id, [FromBody] PaisDto PaisDto)
        {
            if (PaisDto == null)
                return NotFound(new ApiResponse(404, $"El Pais solicitado no existe."));

            var PaisBd = await _unitOfWork.Paises.GetByIdAsync(id);
            if (PaisBd == null)
                return NotFound(new ApiResponse(404, $"El Pais solicitado no existe."));

            var Pais = _mapper.Map<Pais>(PaisDto);
            _unitOfWork.Paises.Update(Pais);
            await _unitOfWork.SaveAsync();
            return PaisDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var Pais = await _unitOfWork.Paises.GetByIdAsync(id);
            if (Pais == null)
                return NotFound(new ApiResponse(404, $"El Pais solicitado no existe."));

            _unitOfWork.Paises.Remove(Pais);
            await _unitOfWork.SaveAsync();

            return NoContent();
        }
    }
}