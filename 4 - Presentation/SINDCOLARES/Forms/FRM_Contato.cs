using Servicos;

namespace SINDCOLARES.Formularios;

public partial class FRM_Contato : Form
{
    private readonly ICadastroService _Service;
    public FRM_Contato(ICadastroService service)
    {
        _Service = service;
        InitializeComponent();
        TXB_Email.Text = _Service.AssociadoTemp.Contato.Email;
        TXB_Telefone.Text = _Service.AssociadoTemp.Contato.Telefone;
    }

    private void BTN_Salvar_Click(object sender, EventArgs e)
    {
        _Service.AssociadoTemp.Contato.Telefone = TXB_Telefone.Text;
        _Service.AssociadoTemp.Contato.Email = TXB_Email.Text;
        MessageBox.Show("Dados atualizados.", "Sucesso!");
        Close();
    }

    private void BTN_Cancelar_Click(object sender, EventArgs e)
    {
        Close();
    }
}