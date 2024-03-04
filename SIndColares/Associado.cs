namespace Models;

public class Associado
{
    public int Id { get; set; } = 0;
    public string Nome { get; set; } = string.Empty;
    public string Sexo { get; set; } = string.Empty;
    public string Apelido { get; set; } = string.Empty;
    public Contato Contato { get; set; } = new();
    public Endereco Endereco { get; set; } = new();
    public Profissao InfoProfissao { get; set; } = new();
    public Documentacao Documentacao { get; set; } = new();
    public DateTime DataNascimento { get; set; } = DateTime.Now;

    public Associado(string cpf, string nome)
    {
        Id = Convert.ToInt32(cpf);
        Nome = nome;
        Documentacao.CPF = cpf;
    }
}