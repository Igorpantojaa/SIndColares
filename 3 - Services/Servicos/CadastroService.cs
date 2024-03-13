using Modelos;
using Infraestrutura;
using Infraestrutura.DTOs;

namespace Servicos;

public class CadastroService : ICadastroService
{
    private Associado _Associado;
    private readonly IAssociadoDTO _DTO;
    public Associado InfoAssociado { get { return _Associado; } }

    public CadastroService(IAssociadoDTO dto)
    {
        _DTO = dto;
        _Associado = new();
    }

    public void LimparCadastro()
    {
        _Associado = new();
    }
    public void PastaAssociado()
    {
        var cpf = _Associado.Documentos.CPF;
        var nome = _Associado.Nome;
        _Associado.Digitalizados.Local = GestaoArquivos.DiretorioAssociado(cpf, nome);
    }
    public void Salvar()
    {
        _DTO.Salvar(_Associado);
        LimparCadastro();
    }
    public void Excluir()
    {
        Directory.Delete(_Associado.Digitalizados.Local, true);
        _DTO.Excluir(_Associado);
        LimparCadastro();
    }
    public void Cancelar()
    {
        if (_Associado.Id == 0 && Directory.Exists(_Associado.Digitalizados.Local))
        {
            Directory.Delete(_Associado.Digitalizados.Local, true);
        }
    }
    public void Recuperar(int id)
    {
        _Associado = _DTO.Recuperar(id);
    }
    public List<Associado> ListarTodos() => _DTO.ListarTodos();

    public string ImagemAssociado(int id)
    {
        return _DTO.Recuperar(id).GetFoto;
    }
}