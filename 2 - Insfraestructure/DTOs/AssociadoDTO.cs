using Microsoft.EntityFrameworkCore;
using Modelos;

namespace Infraestrutura.DTOs;

public class AssociadoDTO : IAssociadoDTO
{
    private readonly SindContext _context;

    public AssociadoDTO(SindContext context)
    {
        _context = context;
    }

    public void Salvar(Associado a)
    {
        try
        {
            if(a.Id == 0)
            {
                if(CPFNaBase(a) == false)
                {
                    _context.Associados.Add(a);
                }
                else
                {
                    var associado = RecuperaPeloCPF(a.GetCPF);
                    throw new Exception($"CPF já cadastrado no associado:\n{associado!.Nome}");
                }
            }  
            else _context.Associados.Update(a);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public void Excluir(Associado a)
    {
        try
        {
            _context.Associados.Remove(a);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro ao remover registro: \n{ex.Message}");
        }
    }
    public List<Associado> ListarTodos()
    {
        try
        {
            var l = _context.Associados
                    .Include(a => a.Contato)
                    .Include(a => a.Documentos)
                    .Include(a => a.Documentos.RG)
                    .Include(a => a.Endereco)
                    .Include(a => a.Escolaridade)
                    .Include(a => a.Filiacao)
                    .Include(a => a.Profissao)
                    .ToList();
            return l;
        }
        catch (Exception ex)
        {
            return new List<Associado>();
            throw new Exception($"Erro ao recuperar registros: \n{ex.Message}");
        }
    }
    public Associado Recuperar(int id)
    {
        try
        {
            var a = _context.Associados                    
                    .Include(a => a.Contato)
                    .Include(a => a.Digitalizados)
                    .Include(a => a.Documentos)
                    .Include(a => a.Documentos.RG)
                    .Include(a => a.Endereco)
                    .Include(a => a.Escolaridade)
                    .Include(a => a.Filiacao)
                    .Include(a => a.Profissao)
                    .Include(a => a.Profissao.ProdutoPesca)
                    .FirstOrDefault(x => x.Id == id);
            if(a != null)
            {
                return a;
            }
            else
            {
                return new();
            }

        }
        catch (Exception ex)
        {
            return new(); 
            throw new Exception($"Erro ao recuperar registro: \n{ex.Message}");
        }
    }
    public bool CPFNaBase(Associado associado)
    {
        var a = RecuperaPeloCPF(associado.Documentos.CPF);
        if (a.Id != 0) return true;
        else return false;
    }
    private Associado RecuperaPeloCPF(string CPF)
    {
        var a = _context.Associados
                .Include(a => a.Documentos)
                .FirstOrDefault(x => x.Documentos.CPF == CPF);
        if (a != null) return a;
        else return new();
    }
}