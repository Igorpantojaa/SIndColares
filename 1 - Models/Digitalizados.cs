namespace Modelos;

public  class Digitalizados
{
    public int Id { get; set; }
    public int AssociadoId { get; set; }
    public string Local {  get; set; } = string.Empty;
    public string CPF { get; set; } = string.Empty;
    public string RG { get; set; } = string.Empty;
    public string Foto { get; set; } = string.Empty;
    public string Filiacao { get; set; } = string.Empty;
    public string Residencia { get; set; } = string.Empty;
    public string Autorizacao { get; set; } = string.Empty;
    public string ReqLicensa { get; set; } = string.Empty;
    public string ReqINSS { get; set; } = string.Empty;
    public string CanhotoProtocolo { get; set; } = string.Empty;
}