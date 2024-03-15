using Servicos;
using Infraestrutura;
using SINDCOLARES.Formularios;
using SINDCOLARES.Forms;


namespace SINDCOLARES;

public partial class FRM_Inicio : Form
{
    private readonly ICadastroService _servico;
    public FRM_Inicio(SindContext context)
    {
        _servico = new CadastroService(context);
        InitializeComponent();
        GestaoArquivos.CriarDiretorioDeArquivos();
    }

    private void BTN_NovoCadastro_Click(object sender, EventArgs e)
    {
        FRM_Cadastro cad = new(_servico);
        cad.ShowDialog();
    }

    private void BTN_PesquisarCadastro_Click(object sender, EventArgs e)
    {
        new FRM_GestaoAssociados(_servico).ShowDialog();
    }

    private void BTN_Periodos_Click(object sender, EventArgs e)
    {
        new FRM_GestaoPeriodos(_servico).ShowDialog();
    }

    private void BTN_GeraDocumentos_Click(object sender, EventArgs e)
    {
        new FRM_GerarDocumentos(_servico).ShowDialog();
    }
}