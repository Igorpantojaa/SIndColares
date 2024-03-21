using Servicos;
using Servicos.ComboBox;

namespace SINDCOLARES.Formularios;

public partial class FRM_Endereco : Form
{
    private readonly ICadastroService _service;
    public FRM_Endereco(ICadastroService service)
    {
        _service = service;
        InitializeComponent();
        CB_UF.DataSource = ConteudoComboBox.Estados();
    }

    private void BTN_Salvar_Click(object sender, EventArgs e)
    {
        _service.AssociadoTemp.Endereco.CEP = TXB_CEP.Text;
        _service.AssociadoTemp.Endereco.UF = CB_UF.Text;
        _service.AssociadoTemp.Endereco.Municipio = TXB_Municipio.Text;
        _service.AssociadoTemp.Endereco.Localidade = TXB_Localidade.Text;
        _service.AssociadoTemp.Endereco.Bairro = TXB_Bairro.Text;
        _service.AssociadoTemp.Endereco.Rua = TXB_Rua.Text;
        _service.AssociadoTemp.Endereco.Numero = TXB_Numero.Text;
        MessageBox.Show("Dados atualizados.", "Sucersso!");
        Close();
    }

    private void BTN_Cancelar_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void FRM_Endereco_Load(object sender, EventArgs e)
    {
        TXB_CEP.Text = _service.AssociadoTemp.Endereco.CEP;
        CB_UF.Text = _service.AssociadoTemp.Endereco.UF;
        TXB_Municipio.Text = _service.AssociadoTemp.Endereco.Municipio;
        TXB_Localidade.Text = _service.AssociadoTemp.Endereco.Localidade;
        TXB_Bairro.Text = _service.AssociadoTemp.Endereco.Bairro;
        TXB_Rua.Text = _service.AssociadoTemp.Endereco.Rua;
        TXB_Numero.Text = _service.AssociadoTemp.Endereco.Numero;
    }
}
