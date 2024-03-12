namespace Modelos;

public class Filiacao
{
    public int Id { get; set; }
    public int AssociadoId { get; set; }
    public bool Filiado { get; set; } = true;
    public string TipoEntidade { get; set; } = "Sindicato";
    public string NomeEntidade { get; set; } = "SINDICATO DOS PESCADORES E AQUICULTORES DO MUNICÍPIO DE COLARES PARÁ";
    public string CNPJEntidade { get; set; } = "21.050.162/0001-04";
    public string UFEntidade { get; set; } = "PA";
}
