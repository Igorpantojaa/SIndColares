using Infraestrutura.DTOs;
using Modelos;
using Servicos.Utilidades;

namespace Servicos;

public interface ICadastroService
{
    Associado AssociadoTemp { get; }
    public IPeriodoDTO PeriodoService { get; } 
    void LimparCadastro();
    void PastaAssociado();
    void Salvar();
    void Excluir(int id);
    void Cancelar();
    bool CPFnaBase();
    void Recuperar(int id);
    string ImagemAssociado(int id);
    public void LimparPeriodo();
    List<Associado> ListarAssociados();
    public Periodo PeriodoTemp { get; set; }
    GeraDocumentos SalvaDocumentos(string destino);
}