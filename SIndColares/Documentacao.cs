namespace Models;

public class Documentacao
{
    public int Id { get; set; } = 0;
    public RG RG { get; set; } = new();
    public string CPF { get; set; } = string.Empty;
    public string PIS { get; set; } = string.Empty;
}
