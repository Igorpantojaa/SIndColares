using Modelos;

namespace Infraestrutura.DTOs
{
    public interface IAssociadoDTO
    {
        void Salvar(Associado a);
        void Excluir(Associado a);
        void Atualizar(Associado a);
        List<Associado> ListarTodos();
    }
}