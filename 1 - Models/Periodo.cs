using Xceed.Document.NET;

namespace Modelos;

public class Periodo
{
    public int Id { get; set; }
    public string AnoVigencia { get; set; } = DateTime.Now.Year.ToString();
    public DateTime DataPublicacao { get; set; } = DateTime.Now;
    public DateTime InicioPeriodo1 { get; set; } = DateTime.Now;
    public DateTime InicioPeriodo2 { get; set; } = DateTime.Now;
    public DateTime FimPeriodo1 { get; set; } = DateTime.Now;
    public DateTime FimPeriodo2 { get; set; } = DateTime.Now;
    public bool Periodo1Ativo { get; set; } = false;
    public bool Periodo2Ativo { get; set; } = false;
    public string Especies { get; set; } = "GURIJUBA (SCIADES PARKERI)";
}
