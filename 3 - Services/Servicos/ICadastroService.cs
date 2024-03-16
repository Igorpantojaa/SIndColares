using Modelos;
using Servicos.Utilidades;

namespace Servicos;

public interface ICadastroService
{
    Associado InfoAssociado { get; }
    void LimparCadastro();
    void PastaAssociado();
    void Salvar();
    void Excluir(int id);
    void Cancelar();
    bool CPFnaBase();
    void Recuperar(int id);
    string ImagemAssociado(int id);
    List<Associado> ListarAssociados();

     Periodo Periodo { get; }
    void SalvarPeriodo();
    void ExcluirPeriodo();
    void LimpaPeriodo();
    void RecuperarPeriodo(int id);
    List<Periodo> ListarPeriodos();

    GeraDocumentos SalvaDocumentos(string destino);
}