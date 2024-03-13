using Modelos;

namespace Servicos;

public interface ICadastroService
{
    public Associado InfoAssociado { get; }
    public void LimparCadastro();
    public void PastaAssociado();
    public void Salvar();
    public void Excluir();
    public void Cancelar();
    public void Recuperar(int id);
    public string ImagemAssociado(int id);
    public List<Associado> ListarTodos();
}