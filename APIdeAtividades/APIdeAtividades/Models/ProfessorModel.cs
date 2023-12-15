namespace APIdeAtividades.Models
{
    public class ProfessorModel
    {
        public int Id { get; set;}
        public required string Nome { get; set;}
        public string? Email { get; set; }
        public string? Materia { get; set; }
    }
}
