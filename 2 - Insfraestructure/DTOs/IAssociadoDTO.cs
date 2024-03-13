using Modelos;

namespace Infraestrutura.DTOs
{
    public interface IAssociadoDTO
    {
        void Salvar(Associado a);
        void Excluir(Associado a);
        bool CPFNaBase(Associado a);
        Associado Recuperar(int id);
        List<Associado> ListarTodos();
        
    }
}