namespace Modelos;

public class Periodo
{
    public int Id { get; set; } = 0;
    public string AnoVigencia { get { return InicioPeriodo1.Year.ToString(); } }
    public string NumeroPublicacao { get; set; } = string.Empty;
    public DateTime DataPublicacao { get; set; } = DateTime.Now;
    public DateTime InicioPeriodo1 { get; set; } = DateTime.Now;
    public DateTime InicioPeriodo2 { get; set; } = DateTime.Now;
    public DateTime FimPeriodo1 { get; set; } = DateTime.Now;
    public DateTime FimPeriodo2 { get; set; } = DateTime.Now;
    public bool Periodo1Ativo { get; set; } = false;
    public bool Periodo2Ativo { get; set; } = false;
    public string Especies { get; set; } = "GURIJUBA (SCIADES PARKERI)";

    public string GetDataPublicacao { get { return DataPublicacao.ToShortDateString(); } }
    public string GetInicioVigencia1 { get { return ValidadeVigencia(InicioPeriodo1.ToShortDateString(), Periodo1Ativo); } }
    public string GetInicioVigencia2 { get { return ValidadeVigencia(InicioPeriodo2.ToShortDateString(), Periodo2Ativo); } }
    public string GetFimVigencia1 { get { return ValidadeVigencia(FimPeriodo1.ToShortDateString(), Periodo1Ativo); } }
    public string GetFimVigencia2 { get { return ValidadeVigencia(FimPeriodo2.ToShortDateString(), Periodo2Ativo); } }

    private static string ValidadeVigencia(string vigenvia, bool valida)
    {
        if (valida) return vigenvia;
        else return string.Empty;
    }
}