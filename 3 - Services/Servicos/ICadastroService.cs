using Modelos;

namespace Servicos;

public interface ICadastroService
{
    Associado InfoAssociado { get; }
    void LimparCadastro();
    void PastaAssociado();
    void Salvar();
    void Excluir();
    void Cancelar();
    bool CPFnaBase();
    void Recuperar(int id);
    string ImagemAssociado(int id);
    List<Associado> ListarTodos();

     Periodo Periodo { get; }
    void SalvarPeriodo();
    void ExcluirPeriodo();
    void LimpaPeriodo();
    void RecuperarPeriodo(int id);
}