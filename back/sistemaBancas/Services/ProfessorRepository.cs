namespace sistemaBancas.Services;

using sistemaBancas.Models;

public interface ProfessorRepository
{
    Task<IEnumerable<Professor>> GetProfessores();
    Task<Professor?> GetProfessorById(long id);

    Task<Professor> AddProfessor(Professor professor);
}