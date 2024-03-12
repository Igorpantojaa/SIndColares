namespace Modelos;

public class Escolaridade
{
    public int Id { get; set; }
    public int AssociadoId { get; set; }
    public string Formacao { get; set; } = string.Empty;
    public string Autodeclaracao { get; set; } = string.Empty;
}
