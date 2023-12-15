using System.ComponentModel;

namespace APIdeAtividades.Enums
{
    public enum StatusAtividade
    {
        [Description("Atividade Postada")]
        Postada = 1,
        [Description("Atividade em Andamento")]
        EmAndamento =2,
        [Description("Atividade Finalizada")]
        Finalizada =3
    }
}
