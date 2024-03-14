using Modelos;

namespace Infraestrutura.DTOs
{
    public interface IPeriodoDTO
    {
        void Salvar(Periodo p);
        void Excluir(Periodo p);
        Periodo Recuperar(int id);
        List<Periodo> ListarTodos();
    }
}