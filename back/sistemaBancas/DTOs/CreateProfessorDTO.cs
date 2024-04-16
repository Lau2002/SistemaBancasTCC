namespace sistemaBancas.DTOs;

using System.ComponentModel.DataAnnotations;

public class CreateProfessorDTO
{
    [Required(ErrorMessage = "E-mail é obrigatório")]
    public string? Email {get; set;}
    public string? Senha {get; set;}
}