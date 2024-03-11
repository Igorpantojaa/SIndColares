using Infraestrutura.DTOs;
using Modelos;

namespace Servicos;

public class CadastroService : ICadastroService
{
    private Associado _Associado;
    private readonly IAssociadoDTO _DTO;
    public IAssociadoDTO Operacoes { get { return _DTO; } }
    public Associado InfoAssociado { get { return _Associado; } }

    public CadastroService(IAssociadoDTO dto)
    {
        _DTO = dto;
        _Associado = new();
    }

    public void NovoCadastro(string cpf)
    {
        _Associado = new();
        _Associado.Id = Convert.ToInt32(cpf);
        _Associado.Documentos.CPF = cpf;
    }

    public void LimparCadastro()
    {
        _Associado = new();
    }
}