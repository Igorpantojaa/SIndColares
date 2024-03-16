using Xceed.Document.NET;

namespace Modelos;

public class Periodo
{
    public int Id { get; set; } = 0;
    public string AnoVigencia { get { return DataPublicacao.Year.ToString(); } }
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
    public string GetInicioVigencia1 { get { return ValidaDatas(Periodo1Ativo, InicioPeriodo1); } }
    public string GetInicioVigencia2 { get { return ValidaDatas(Periodo2Ativo, InicioPeriodo2); } }
    public string GetFimVigencia1 { get { return ValidaDatas(Periodo1Ativo, FimPeriodo1); } }
    public string GetFimVigencia2 { get { return ValidaDatas(Periodo2Ativo, FimPeriodo2); } }

    private static string ValidaDatas(bool ativo, DateTime Data)
    {
        if (!ativo) return string.Empty;
        else return Data.ToShortDateString();
    }
}
