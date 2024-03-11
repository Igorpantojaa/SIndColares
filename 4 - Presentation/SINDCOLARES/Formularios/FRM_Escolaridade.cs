using Servicos;

namespace SINDCOLARES.Formularios;

public partial class FRM_Escolaridade : Form
{
    private readonly ICadastroService _service;
    public FRM_Escolaridade(ICadastroService service)
    {
        _service = service;
        InitializeComponent();
    }
    private void BTN_Salvar_Click(object sender, EventArgs e)
    {
        _service.InfoAssociado.Escolaridade.Autodeclaracao = CB_Escolarridade.SelectedText;
        _service.InfoAssociado.Escolaridade.Formacao = TXB_Declaração.Text;
        MessageBox.Show("Dados atualizados.", "Sucesso!");
        Close();
    }

    private void BTN_Cancelar_Click(object sender, EventArgs e)
    {
        Close();
    }
}
