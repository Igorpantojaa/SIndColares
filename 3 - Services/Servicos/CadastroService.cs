using Modelos;
using Infraestrutura;
using Infraestrutura.DTOs;

namespace Servicos;

public class CadastroService : ICadastroService
{
    private Periodo _periodo;
    private Associado _associado;
    private readonly IPeriodoDTO _periodoDTO;
    private readonly IAssociadoDTO _associadoDTO;

    public Periodo Periodo { get { return _periodo; } }
    public Associado InfoAssociado { get { return _associado; } }

    public CadastroService(IAssociadoDTO associadoDTO, IPeriodoDTO periodoDTO)
    {
        _associadoDTO = associadoDTO;
        _periodoDTO = periodoDTO;
        _associado = new();
        _periodo = new();
    }

    public void LimparCadastro()
    {
        _associado = new();
    }
    public void PastaAssociado()
    {
        try
        {
            if(_associadoDTO.CPFNaBase(_associado) != true)
            {
                var cpf = _associado.Documentos.CPF;
                var nome = _associado.Nome;
                _associado.Digitalizados.Local = GestaoArquivos.DiretorioAssociado(cpf, nome);
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
            _associadoDTO.Salvar(_associado);
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
            Directory.Delete(_associado.Digitalizados.Local, true);
            _associadoDTO.Excluir(_associado);
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
            if (_associado.Id == 0 && Directory.Exists(_associado.Digitalizados.Local))
            {
                Directory.Delete(_associado.Digitalizados.Local, true);
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
            return _associadoDTO.CPFNaBase(_associado);
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
            _associado = _associadoDTO.Recuperar(id);
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
            return _associadoDTO.ListarTodos();
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
            return _associadoDTO.Recuperar(id).GetFoto;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void SalvarPeriodo()
    {
        try
        {
            _periodoDTO.Salvar(_periodo);
            LimparCadastro();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public void ExcluirPeriodo()
    {
        try
        {
            _periodoDTO.Excluir(_periodo);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public void RecuperarPeriodo(int id)
    {
        try
        {
            _periodo = _periodoDTO.Recuperar(id);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void LimpaPeriodo()
    {
        _periodo = new();
    }
}