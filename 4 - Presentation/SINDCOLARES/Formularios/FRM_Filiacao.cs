using Servicos;

namespace SINDCOLARES.Formularios;

public partial class FRM_Filiacao : Form
{
    private readonly ICadastroService _service;
    public FRM_Filiacao(ICadastroService service)
    {
        _service = service;
        InitializeComponent();
    }

    private void BTN_Cancelar_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void BTN_Salvar_Click(object sender, EventArgs e)
    {
        _service.InfoAssociado.Filiacao.NomeEntidade = TXB_NomeEntidade.Text;
        _service.InfoAssociado.Filiacao.UFEntidade = CB_UF.SelectedText;
        _service.InfoAssociado.Filiacao.TipoEntidade = CB_TipoEntidade.SelectedText;
        _service.InfoAssociado.Filiacao.CNPJEntidade = TXB_CNPJ.Text;
        if(CHB_Filiacao.Checked == true)
        {
            _service.InfoAssociado.Filiacao.Filiado = true;
        }
        else
        {
            _service.InfoAssociado.Filiacao.Filiado = false;
        }
        MessageBox.Show("Dados atualizados.", "Sucesso!");
        Close();
    }
}
