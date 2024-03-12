using Servicos;
using Servicos.ComboBox;

namespace SINDCOLARES.Formularios;

public partial class FRM_Filiacao : Form
{
    private readonly ICadastroService _service;
    public FRM_Filiacao(ICadastroService service)
    {
        _service = service;
        InitializeComponent();
        CB_UF.DataSource = ConteudoComboBox.Estados();
        CB_TipoEntidade.DataSource = ConteudoComboBox.TipoEntidade();
    }

    private void BTN_Cancelar_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void BTN_Salvar_Click(object sender, EventArgs e)
    {
        _service.InfoAssociado.Filiacao.NomeEntidade = TXB_NomeEntidade.Text;
        _service.InfoAssociado.Filiacao.UFEntidade = CB_UF.Text;
        _service.InfoAssociado.Filiacao.TipoEntidade = CB_TipoEntidade.Text;
        _service.InfoAssociado.Filiacao.CNPJEntidade = TXB_CNPJ.Text;
        if (CHB_Filiacao.Checked == true)
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

    private void FRM_Filiacao_Load(object sender, EventArgs e)
    {
        TXB_NomeEntidade.Text = _service.InfoAssociado.Filiacao.NomeEntidade;
        CB_UF.Text = _service.InfoAssociado.Filiacao.UFEntidade;
        CB_TipoEntidade.Text = _service.InfoAssociado.Filiacao.TipoEntidade;
        TXB_CNPJ.Text = _service.InfoAssociado.Filiacao.CNPJEntidade;
        CHB_Filiacao.Checked = _service.InfoAssociado.Filiacao.Filiado;
    }
}
