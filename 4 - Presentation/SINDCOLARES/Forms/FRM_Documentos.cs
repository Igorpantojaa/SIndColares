using Servicos;
using Servicos.ComboBox;

namespace SINDCOLARES.Formularios;

public partial class FRM_Documentos : Form
{
    private readonly ICadastroService _service;
    public FRM_Documentos(ICadastroService service)
    {
        _service = service;
        InitializeComponent();
        CB_EstadoEmissao.DataSource = ConteudoComboBox.Estados();
    }

    private void BTN_Salvar_Click(object sender, EventArgs e)
    {
        _service.AssociadoTemp.Documentos.CPF = TXB_CPF.Text;
        _service.AssociadoTemp.Documentos.PIS = TXB_PIS.Text;
        _service.AssociadoTemp.Documentos.RG.Numero = TXB_RG.Text;
        _service.AssociadoTemp.Documentos.RG.DataEmisao = DTP_DataEmissao.Value;
        _service.AssociadoTemp.Documentos.RG.NomePai = TXB_NomePai.Text;
        _service.AssociadoTemp.Documentos.RG.NomeMae = TXB_NomeMae.Text;
        _service.AssociadoTemp.Documentos.RG.OrgaoEmissor = TXB_OrgaoEmissor.Text;
        _service.AssociadoTemp.Documentos.RG.EstadoEmissao = CB_EstadoEmissao.Text;
        MessageBox.Show("Dados atualizados.", "Sucersso!");
        Close();
    }

    private void BTN_Cancelar_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void FRM_Documentos_Load(object sender, EventArgs e)
    {
        TXB_CPF.Text = _service.AssociadoTemp.Documentos.CPF;
        TXB_PIS.Text = _service.AssociadoTemp.Documentos.PIS;
        TXB_RG.Text = _service.AssociadoTemp.Documentos.RG.Numero;
        DTP_DataEmissao.Value = _service.AssociadoTemp.Documentos.RG.DataEmisao;
        TXB_NomePai.Text = _service.AssociadoTemp.Documentos.RG.NomePai;
        TXB_NomeMae.Text = _service.AssociadoTemp.Documentos.RG.NomeMae;
        TXB_OrgaoEmissor.Text = _service.AssociadoTemp.Documentos.RG.OrgaoEmissor;
        CB_EstadoEmissao.Text = _service.AssociadoTemp.Documentos.RG.EstadoEmissao;
    }
}
