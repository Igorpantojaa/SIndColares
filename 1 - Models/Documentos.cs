namespace Models;

public class Documentos
{
    public int Id { get; set; }
    public int AssociadoId { get; set; }
    public RG RG { get; set; } = new();
    public string CPF { get; set; } = string.Empty;
    public string PIS { get; set; } = string.Empty;
}
