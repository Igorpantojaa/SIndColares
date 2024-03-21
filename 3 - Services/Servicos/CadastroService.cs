using Modelos;
using Infraestrutura;
using Infraestrutura.DTOs;
using Servicos.Utilidades;

namespace Servicos;

public class CadastroService : ICadastroService
{

    private Associado _associado;
    private readonly IPeriodoDTO _periodoDTO;
    private readonly IAssociadoDTO _associadoDTO;

    public Periodo PeriodoTemp { get; set; }
    public Associado AssociadoTemp { get { return _associado; } }
    public IPeriodoDTO PeriodoService {  get { return _periodoDTO; } }

    public CadastroService(SindContext context)
    {
        _associadoDTO = new AssociadoDTO(context);
        _periodoDTO = new PeriodoDTO(context);
        _associado = new();
        PeriodoTemp = new();
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
    public void Excluir(int id)
    {
        try
        {
            LimparCadastro();
            Recuperar(id);
            _associadoDTO.Excluir(_associado);
            GestaoArquivos.ExcluirDiretorioAssociado(_associado.Digitalizados.Local);
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
                GestaoArquivos.ExcluirDiretorioAssociado(_associado.Digitalizados.Local);
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
    public void LimparCadastro()
    {
        _associado = new();
    }
    public void PastaAssociado()
    {
        try
        {
            if(!_associadoDTO.CPFNaBase(_associado))
            {
                var cpf = _associado.Documentos.CPF;
                var nome = _associado.Nome;
                _associado.Digitalizados.Local = GestaoArquivos.CriarDiretorioAssociado(cpf);
            }
        }
        catch
        {
            throw;
        }
    }
    public void Recuperar(int id)
    {
        try
        {
            _associado = _associadoDTO.Recuperar(id);
        }
        catch
        {
            throw;
        }
    }
    public void LimparPeriodo()
    {
        PeriodoTemp = new();
    }
    public string ImagemAssociado(int id)
    {
        try
        {
            return _associadoDTO.Recuperar(id).GetFoto;
        }
        catch
        {
            throw;
        }
    }
    public List<Associado> ListarAssociados()
    {
        try
        {
            return _associadoDTO.ListarTodos();
        }
        catch
        {
            throw;
        }
    }
    public GeraDocumentos SalvaDocumentos(string destino)
    {
        return new GeraDocumentos(_associado, PeriodoTemp, destino);
    }
}