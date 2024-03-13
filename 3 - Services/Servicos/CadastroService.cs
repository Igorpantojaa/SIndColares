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
        try
        {
            if(_DTO.CPFNaBase(_Associado) != true)
            {
                var cpf = _Associado.Documentos.CPF;
                var nome = _Associado.Nome;
                _Associado.Digitalizados.Local = GestaoArquivos.DiretorioAssociado(cpf, nome);
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public void Salvar()
    {
        try
        {
            _DTO.Salvar(_Associado);
            LimparCadastro();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public void Excluir()
    {
        try
        {
            Directory.Delete(_Associado.Digitalizados.Local, true);
            _DTO.Excluir(_Associado);
            LimparCadastro();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public void Cancelar()
    {
        try
        {
            if (_Associado.Id == 0 && Directory.Exists(_Associado.Digitalizados.Local))
            {
                Directory.Delete(_Associado.Digitalizados.Local, true);
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public bool CPFnaBase()
    {
        try
        {
            return _DTO.CPFNaBase(_Associado);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public void Recuperar(int id)
    {
        try
        {
            _Associado = _DTO.Recuperar(id);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public List<Associado> ListarTodos()
    {
        try
        {
            return _DTO.ListarTodos();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public string ImagemAssociado(int id)
    {
        try
        {
            return _DTO.Recuperar(id).GetFoto;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}