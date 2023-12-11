using API.Dtos;
using API.Helpers;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    public class DepartamentoController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DepartamentoController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<DepartamentoDto>>> Get11()
        {
            var Departamentos = await _unitOfWork.Departamentos.GetAllAsync();
            return _mapper.Map<List<DepartamentoDto>>(Departamentos);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<DepartamentoDto>> Get(int id)
        {
            var Departamento = await _unitOfWork.Departamentos.GetByIdAsync(id);
            if (Departamento == null)
                return NotFound(new ApiResponse(404, $"El Departamento solicitado no existe."));

            return _mapper.Map<DepartamentoDto>(Departamento);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Departamento>> Post(DepartamentoDto DepartamentoDto)
        {
            var Departamento = _mapper.Map<Departamento>(DepartamentoDto);
            _unitOfWork.Departamentos.Add(Departamento);
            await _unitOfWork.SaveAsync();
            if (Departamento == null)
                return BadRequest(new ApiResponse(400));

            DepartamentoDto.Id = Departamento.Id;
            return CreatedAtAction(nameof(Post), new { id = DepartamentoDto.Id }, DepartamentoDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<DepartamentoDto>> Put(int id, [FromBody] DepartamentoDto DepartamentoDto)
        {
            if (DepartamentoDto == null)
                return NotFound(new ApiResponse(404, $"El Departamento solicitado no existe."));

            var DepartamentoBd = await _unitOfWork.Departamentos.GetByIdAsync(id);
            if (DepartamentoBd == null)
                return NotFound(new ApiResponse(404, $"El Departamento solicitado no existe."));

            var Departamento = _mapper.Map<Departamento>(DepartamentoDto);
            _unitOfWork.Departamentos.Update(Departamento);
            await _unitOfWork.SaveAsync();
            return DepartamentoDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var Departamento = await _unitOfWork.Departamentos.GetByIdAsync(id);
            if (Departamento == null)
                return NotFound(new ApiResponse(404, $"El Departamento solicitado no existe."));

            _unitOfWork.Departamentos.Remove(Departamento);
            await _unitOfWork.SaveAsync();

            return NoContent();
        }
    }
}