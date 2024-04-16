namespace sistemaBancas.Services;

using sistemaBancas.Models;
using Microsoft.EntityFrameworkCore;

public class ProfessorService : ProfessorRepository
{
    private readonly Context _context;

    public ProfessorService(Context context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Professor>> GetProfessores() 
    {
        return await _context.Professores
                        .OrderBy(p => p.Id)
                        .ToListAsync();
    }

    public async Task<Professor?> GetProfessorById(long id) 
    {
        return await _context.Professores
                    .Where(p => p.Id == id)
                    .FirstOrDefaultAsync();
    }

    public async Task<Professor> AddProfessor(Professor professor)
    {
        await _context.Professores.AddAsync(professor);
        await _context.SaveChangesAsync();
        return professor;
    }
}