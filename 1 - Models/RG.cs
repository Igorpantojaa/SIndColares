namespace Modelos;

public class RG
{
    public int Id { get; set; }
    public int AssociadoId { get; set; }
    public DateTime DataEmisao { get; set; } = DateTime.Now;
    public string Numero { get; set; } = string.Empty;
    public string NomePai { get; set; } = string.Empty;
    public string NomeMae { get; set; } = string.Empty;
    public string OrgaoEmissor { get; set; } = string.Empty;
    public string EstadoEmissao { get; set; } = string.Empty;
}