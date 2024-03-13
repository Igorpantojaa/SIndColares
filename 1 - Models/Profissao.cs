namespace Modelos;

public class Profissao
{
    public int Id { get; set; }
    public int AssociadoId { get; set; }
    public string Categoria { get; set; } = "Artesanal";
    public string FormaPesca { get; set; } = "Desembarcado";
    public string NomeEmbarcacao { get; set; } = string.Empty;
    public string RGP { get; set; } = string.Empty;
    public string AB { get; set; } = string.Empty;
    public ProdutosPesca ProdutoPesca { get; set; } = new ();
    public string CPFProprietario {  get; set; } = string.Empty;
    public string AreaPesca { get; set; } = "Rio";
    public string LocalPesca { get; set; } = string.Empty;
    public bool Empregado { get; set; } = false;
    public bool Aposentado { get; set; } = false;
}
