namespace Modelos;

public  class Digitalizados
{
    public bool CPFCarregado { get { if (CPF != string.Empty) { return true; } else { return false; } } }
    public bool RGCarregado { get { if (RG != string.Empty) { return true; } else { return false; } } }
    public bool FiliacaoCarregado { get { if (Filiacao != string.Empty) { return true; } else { return false; } } }
    public bool ResidenciaCarregado { get { if (Residencia != string.Empty) { return true; } else { return false; } } }
    public bool ProcuracaoCarregado { get { if (Procuracao != string.Empty) { return true; } else { return false; } } }
    public bool ReqLicensaCarregado { get { if (RegInicial != string.Empty) { return true; } else { return false; } } }
    public bool ReqINSSCarregado { get { if (ReqINSS != string.Empty) { return true; } else { return false; } } }
    public bool CanhotoProtocoloCarregado { get { if (CanhotoProtocolo != string.Empty) { return true; } else { return false; } } }

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
}