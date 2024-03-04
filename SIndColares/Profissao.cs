namespace Models;

public class Profissao
{
    public string Categoria { get; set; } = string.Empty;
    public string FormaPesca { get; set; } = string.Empty;
    public int RGP { get; set; } = 0;
    public int AB { get; set; } = 0;
    public string ProdutoPesca {  get; set; } = string.Empty;
    public string AreaPesca { get; set; } = string.Empty;
    public string LocalPesca {  get; set; } = string.Empty;
    public bool Empregado { get; set; } = false;
    public bool Aposentado { get; set; } = false;
}
