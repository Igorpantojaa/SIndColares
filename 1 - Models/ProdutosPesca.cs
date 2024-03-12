namespace Modelos;

public class ProdutosPesca
{
    public int Id { get; set; }
    public int AssociadoId { get; set; }
    public bool Peixes { get; set; } = true;
    public bool Crustaceos { get; set; } = false;
    public bool Mariscos { get; set; } = false;
    public bool Algas { get; set; } = false;
    public bool Outros { get; set; } = false;
}