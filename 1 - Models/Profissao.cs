namespace Modelos;

public class Profissao
{
    public int id { get; set; }
    public int AssociadoId { get; set; }
    public string Categoria { get; set; } = string.Empty;
    public string FormaPesca { get; set; } = string.Empty;
    public string NomeEmbarcacao { get; set; } = string.Empty;
    public string RGP { get; set; } = string.Empty;
    public string AB { get; set; } = string.Empty;
    public string ProdutoPesca { get; set; } = string.Empty;
    public string AreaPesca { get; set; } = string.Empty;
    public string LocalPesca { get; set; } = string.Empty;
    public bool Empregado { get; set; } = false;
    public bool Aposentado { get; set; } = false;
}
