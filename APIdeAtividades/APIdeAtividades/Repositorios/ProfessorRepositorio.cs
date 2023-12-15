using APIdeAtividades.Data;
using APIdeAtividades.Models;
using APIdeAtividades.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace APIdeAtividades.Repositorios
{
    public class ProfessorRepositorio : IProfessorRepositorio
    {
        private readonly APIdeAtividadesDBContext _dbContext;
        public ProfessorRepositorio(APIdeAtividadesDBContext APIdeAtividadesDBContext, APIdeAtividadesDBContext dBContext) 
        {
            _dbContext = APIdeAtividadesDBContext;

        }
        public async Task<ProfessorModel> Adicionar(ProfessorModel professor)
        {
            await _dbContext.Professores.AddAsync(professor);
            await _dbContext.SaveChangesAsync();

            return professor;
        }

        public async Task<bool> Apagar(int id)
        {
            ProfessorModel professorPorId = await BuscarPorId(id);

            if (professorPorId == null)
            {
                throw new Exception($"Professor para o ID: {id} não foi localizado!");
            }

            _dbContext.Professores.Remove(professorPorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<ProfessorModel> Atualizar(ProfessorModel professor, int id)
        {
            ProfessorModel professorPorId = await BuscarPorId(id);
            
            if(professorPorId == null) 
            {
                throw new Exception($"Professor para o ID: {id} não foi localizado!");
            }

            professorPorId.Nome = professor.Nome;
            professorPorId.Email = professor.Email;
            professorPorId.Materia = professor.Materia;

            _dbContext.Professores.Update(professorPorId);
            await _dbContext.SaveChangesAsync();

            return professorPorId;
        }

        public async Task<ProfessorModel> BuscarPorId(int id)
        {
            return await _dbContext.Professores.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<ProfessorModel>> BuscarProfessores()
        {
            return await _dbContext.Professores.ToListAsync();
        }
    }
}
