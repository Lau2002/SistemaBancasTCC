using sistemaBancas.Models;

namespace sistemaBancas.DTOs;

public class ProfessorDTO
{
    public long Id {get; set;}
    public string Email {get; set;} = null!;

    public static ProfessorDTO ToDto(Professor model)
    {
        return new ProfessorDTO{
            Id = model.Id,
            Email = model.Email,
        };
    }
}

