using WebConsumoAPI.Models;

namespace WebConsumoAPI.Interfaces
{
    public interface IAtividade
    {
        List<Atividade> List();

        Atividade Participants(int Participantes);

    }
}
