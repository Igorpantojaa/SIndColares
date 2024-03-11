namespace Modelos;

public class Contato
{
    public int id {  get; set; }
    public int AssociadoId { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Telefone { get; set; } = string.Empty;
}
