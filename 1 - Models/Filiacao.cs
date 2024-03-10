namespace Modelos;

public class Filiacao
{
    public int AssociadoId { get; set; }
    public bool Filiado { get; set; } = true;
    public string TipoEntidade { get; set; } = string.Empty;
    public string NomeEntidade { get; set; } = string.Empty;
    public string CNPJEntidade { get; set; } = string.Empty;
    public string UFEntidade { get; set; } = string.Empty;
}
