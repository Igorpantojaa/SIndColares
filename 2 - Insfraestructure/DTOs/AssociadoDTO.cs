using Microsoft.EntityFrameworkCore;
using Models;

namespace Insfraestructure.DTOs;

public class AssociadoDTO : IAssociadoDTO
{
    private readonly SindContext _context;

    public AssociadoDTO()
    {
        _context = new SindContext();
    }

    public void Novo(Associado a)
    {
        try
        {
            _context.Associados.Add(a);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro ao criar novo registro: \n{ex.Message}");
        }
    }

    public void Atualizar(Associado a)
    {
        try
        {
            _context.Associados.Update(a);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro ao alterar novo registro: \n{ex.Message}");
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
}