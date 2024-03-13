using Servicos;
using Infraestrutura;
using Infraestrutura.DTOs;


namespace SINDCOLARES;

public partial class FRM_Inicio : Form
{
    private readonly ICadastroService _servico;
    public FRM_Inicio(IAssociadoDTO context)
    {
        _servico = new CadastroService(context);
        InitializeComponent();
        GestaoArquivos.CriarDiretorioDeArquivos();
    }

    private void BTN_NovoCadastro_Click(object sender, EventArgs e)
    {
        _servico.LimparCadastro();
        FRM_Cadastro cad = new(_servico);
        cad.ShowDialog();
    }

    private void BTN_PesquisarCadastro_Click(object sender, EventArgs e)
    {
        _servico.LimparCadastro();
        new FRM_GestaoAssociados(_servico).ShowDialog();
    }
}