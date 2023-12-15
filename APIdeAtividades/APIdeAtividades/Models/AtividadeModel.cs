using APIdeAtividades.Enums;

namespace APIdeAtividades.Models
{
    public class AtividadeModel
    {
        public int IdAtividade { get; set; }
        public required string NomeAtividade { get; set; }
        public  string? DescricaoAtividade { get; set; }
        public StatusAtividade StatusAtividade { get; set; }
    }
}
