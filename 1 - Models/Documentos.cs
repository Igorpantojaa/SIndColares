namespace Modelos;

public class Documentos
{
    public int AssociadoId { get; set; }
    public RG RG { get; set; } = new();
    public string CPF { get; set; } = string.Empty;
    public string PIS { get; set; } = string.Empty;
}
