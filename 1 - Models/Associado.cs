namespace Modelos;

public class Associado
{
    public int Id { get; set; } = 0;
    public string Nome { get; set; } = string.Empty;
    public string Sexo { get; set; } = string.Empty;
    public string Apelido { get; set; } = string.Empty;
    public Contato Contato { get; set; } = new();
    public Endereco Endereco { get; set; } = new();
    public Filiacao Filiacao { get; set; } = new();
    public Profissao Profissao { get; set; } = new();
    public Documentos Documentos { get; set; } = new();
    public Escolaridade Escolaridade { get; set; } = new();
    public Digitalizados Digitalizados { get; set; } = new();
    public DateTime DataNascimento { get; set; } = DateTime.Now;

    public string GetCPF { get { return Documentos.CPF; } }
    public string GetRG { get { return Documentos.RG.Numero; } }
    public string GetFoto { get { return Digitalizados.Foto; } }
    public string GetDataNascimento { get { return DataNascimento.ToShortDateString(); } }
}