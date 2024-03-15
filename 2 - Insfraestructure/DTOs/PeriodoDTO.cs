using Modelos;

namespace Infraestrutura.DTOs;

public class PeriodoDTO : IPeriodoDTO
{
    private readonly SindContext _context;

    public PeriodoDTO(SindContext context)
    {
        _context = context;
    }

    public void Salvar(Periodo p)
    {
        try
        {
            if(p.Id == 0)
            {
                _context.Periodos.Add(p);
            }  
            else _context.Periodos.Update(p);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public void Excluir(Periodo p)
    {
        try
        {
            _context.Periodos.Remove(p);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro ao remover registro: \n{ex.Message}");
        }
    }
    public Periodo Recuperar(int id)
    {
        try
        {
            var p = _context.Periodos.FirstOrDefault(x => x.Id == id);
            if(p != null)
            {
                return p;
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
    public List<Periodo> ListarTodos()
    {
        try
        {
            var l = _context.Periodos.ToList();
            return l;
        }
        catch (Exception ex)
        {
            return new List<Periodo>();
            throw new Exception($"Erro ao recuperar registros: \n{ex.Message}");
        }
    }
}