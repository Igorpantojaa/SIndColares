using Models;

namespace Insfraestructure.DTOs
{
    public interface IAssociadoDTO
    {
        void Atualizar(Associado a);
        void Excluir(Associado a);
        List<Associado> ListarTodos();
        void Novo(Associado a);
    }
}