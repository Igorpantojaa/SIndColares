using Servicos;
using Servicos.ComboBox;

namespace SINDCOLARES.Formularios;

public partial class FRM_Escolaridade : Form
{
    private readonly ICadastroService _service;
    public FRM_Escolaridade(ICadastroService service)
    {
        _service = service;
        InitializeComponent();
        CB_Escolarridade.DataSource = ConteudoComboBox.Escolaridade();
    }
    private void BTN_Salvar_Click(object sender, EventArgs e)
    {
        _service.InfoAssociado.Escolaridade.Autodeclaracao = CB_DeclaracaoEscolaridade.Text;
        _service.InfoAssociado.Escolaridade.Formacao = CB_Escolarridade.Text;
        MessageBox.Show("Dados atualizados.", "Sucesso!");
        Close();
    }

    private void BTN_Cancelar_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void FRM_Escolaridade_Load(object sender, EventArgs e)
    {
        CB_Escolarridade.Text = _service.InfoAssociado.Escolaridade.Formacao;
        CB_DeclaracaoEscolaridade.Text = _service.InfoAssociado.Escolaridade.Autodeclaracao;
    }
}