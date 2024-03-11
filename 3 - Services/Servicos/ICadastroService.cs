using Infraestrutura.DTOs;
using Modelos;

namespace Servicos;

public interface ICadastroService
{
    public IAssociadoDTO Operacoes { get; }
    public Associado InfoAssociado { get; }
    public void NovoCadastro(string cpf);
    public void LimparCadastro();
    public void CriarPasta();
}