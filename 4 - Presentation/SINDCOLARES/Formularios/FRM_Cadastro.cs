using Servicos;
using SINDCOLARES.Formularios;

namespace SINDCOLARES;

public partial class FRM_Cadastro : Form
{
    private readonly ICadastroService _cadastroService;
    public FRM_Cadastro(ICadastroService cs)
    {
        _cadastroService = cs;
        InitializeComponent();
    }

    private void BTN_Salvar_Click(object sender, EventArgs e) => Salvar();
    private void BTN_Contato_Click(object sender, EventArgs e) => Contato();
    private void BTN_Cancelar_Click(object sender, EventArgs e) => Cancelar();
    private void BTN_Endereco_Click(object sender, EventArgs e) => Endereco();
    private void BTN_filiacao_Click(object sender, EventArgs e) => Filiacao();
    private void BTN_Profissao_Click(object sender, EventArgs e) => Profissao();
    private void BTN_Documentos_Click(object sender, EventArgs e) => Documentos();
    private void BTN_Documentacao_Click(object sender, EventArgs e) => Digitalizados();
    private void BTN_Escolaridade_Click(object sender, EventArgs e) => Escolaridade();

    private void Documentos()
    {
        FRM_Documentos d = new(_cadastroService);
        d.ShowDialog();
    }

    private void Endereco()
    {
        FRM_Endereco e = new(_cadastroService);
        e.ShowDialog();
    }

    private void Contato()
    {
        FRM_Contato c = new(_cadastroService);
        c.ShowDialog();
    }

    private void Escolaridade()
    {
        FRM_Escolaridade e = new(_cadastroService);
        e.ShowDialog();
    }

    private void Filiacao()
    {
        FRM_Filiacao f = new(_cadastroService);
        f.ShowDialog();
    }

    private void Profissao()
    {
        FRM_Profissao p = new(_cadastroService);
        p.ShowDialog();
    }

    private void Digitalizados()
    {
        FRM_CarregaDocumentacao d = new();
        d.ShowDialog();
    }

    private void Salvar()
    {
        throw new NotImplementedException();
    }

    private void Cancelar()
    {
        Close();
    }
}
