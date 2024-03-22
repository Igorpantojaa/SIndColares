namespace Modelos;

public  class Digitalizados
{
    public bool CPFCarregado { get { return ArquivoExistente(CPF); } }
    public bool RGCarregado { get { return ArquivoExistente(RG); } }
    public bool FiliacaoCarregado { get { return ArquivoExistente(Filiacao); } }
    public bool ResidenciaCarregado { get { return ArquivoExistente(Residencia); } }
    public bool ProcuracaoCarregado { get { return ArquivoExistente(Procuracao); } }
    public bool ReqInicialCarregado { get { return ArquivoExistente(RegInicial); } }
    public bool ReqINSSCarregado { get { return ArquivoExistente(ReqINSS); } }
    public bool CanhotoProtocoloCarregado { get { return ArquivoExistente(CanhotoProtocolo); } }

    public int Id { get; set; }
    public int AssociadoId { get; set; }
    public string Local {  get; set; } = string.Empty;
    public string CPF { get; set; } = string.Empty;
    public string RG { get; set; } = string.Empty;
    public string Foto { get; set; } = string.Empty;
    public string Filiacao { get; set; } = string.Empty;
    public string Residencia { get; set; } = string.Empty;
    public string Procuracao { get; set; } = string.Empty;
    public string RegInicial { get; set; } = string.Empty;
    public string ReqINSS { get; set; } = string.Empty;
    public string CanhotoProtocolo { get; set; } = string.Empty;

    private static bool ArquivoExistente(string path)
    {
        if(string.IsNullOrEmpty(path) || !File.Exists(path)) return false;
        else return true;
    }
}