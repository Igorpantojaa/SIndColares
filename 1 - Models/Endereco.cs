
namespace Modelos;

public class Endereco
{
    public int Id { get; set; }
    public int AssociadoId { get; set; }
    public string CEP { get; set; } = "68785-000";
    public string UF { get; set; } = "PA";
    public string Municipio { get; set; } = "Colares";
    public string Localidade { get; set; } = string.Empty;
    public string Bairro { get; set; } = string.Empty;
    public string Rua { get; set; } = string.Empty;
    public string Numero { get; set; } = string.Empty;

    public virtual string GetEndereco => GeraEndereco();
    private string GeraEndereco()
    {

        var endereco = $"{Rua} - Nº {Numero}";
        if (Bairro != string.Empty) endereco = $"{endereco}. {Bairro}";
        return endereco;
    }
}
