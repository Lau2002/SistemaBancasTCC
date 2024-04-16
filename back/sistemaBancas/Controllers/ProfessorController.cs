using Microsoft.AspNetCore.Mvc;
using sistemaBancas.DTOs;
using sistemaBancas.Models;
using sistemaBancas.Services;

namespace sistemaBancas.Controllers;

    [Route("api/[controller]")]
    [ApiController]
public class ProfessorController : ControllerBase
{
    private readonly ProfessorRepository _repository;
    public ProfessorController(ProfessorRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    [Route ("getProfessores")]
    public async Task<IEnumerable<ProfessorDTO>> GetProfessores()
    {
        var professores = await _repository.GetProfessores();
        return professores.Select(p => ProfessorDTO.ToDto(p));
    }

    [HttpGet]
    [Route ("getProfessor/{id}")]
    public async Task<ProfessorDTO> GetProfessorById(long id)
    {
        var professor = await _repository.GetProfessorById(id);
        return ProfessorDTO.ToDto(professor);
    }

    [HttpPost]
    [Route ("addProfessor")]
    public async Task<ActionResult<ProfessorDTO>> AddProfessor(CreateProfessorDTO professorDto)
    {
        var model = new Professor();
        model.Email = professorDto.Email!;
        model.Senha = professorDto.Senha!;

        var newProfessor = await _repository.AddProfessor(model);
        return CreatedAtAction(nameof(GetProfessorById), new {id = newProfessor.Id}, ProfessorDTO.ToDto(newProfessor));
    }
}