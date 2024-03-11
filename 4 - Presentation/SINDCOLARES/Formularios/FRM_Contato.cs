using Servicos;

namespace SINDCOLARES.Formularios;

public partial class FRM_Contato : Form
{
    private readonly ICadastroService _Service;
    public FRM_Contato(ICadastroService service)
    {
        _Service = service;
        InitializeComponent();
    }

    private void BTN_Salvar_Click(object sender, EventArgs e)
    {
        _Service.InfoAssociado.Contato.Telefone = TXB_Telefone.Text;
        _Service.InfoAssociado.Contato.Email = TXB_Email.Text;
        MessageBox.Show("Dados atualizados.", "Sucersso!");
        Close();
    }

    private void BTN_Cancelar_Click(object sender, EventArgs e)
    {
        Close();
    }
}