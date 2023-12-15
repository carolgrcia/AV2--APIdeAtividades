using APIdeAtividades.Models;

namespace APIdeAtividades.Repositorios.Interfaces
{
    public interface IProfessorRepositorio
    {
        Task<List<ProfessorModel>> BuscarProfessores();
        Task<ProfessorModel> BuscarPorId(int id);
        Task<ProfessorModel> Adicionar(ProfessorModel professor);
        Task<ProfessorModel> Atualizar(ProfessorModel professor, int id);
        Task<bool> Apagar(int id);
    }
}
