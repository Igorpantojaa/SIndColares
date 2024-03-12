using Servicos;

namespace SINDCOLARES.Formularios;

public partial class FRM_Documentos : Form
{
    private readonly ICadastroService _service;
    public FRM_Documentos(ICadastroService service)
    {
        _service = service;
        InitializeComponent();
    }

    private void BTN_Salvar_Click(object sender, EventArgs e)
    {
        _service.InfoAssociado.Documentos.CPF = TXB_CPF.Text;
        _service.InfoAssociado.Documentos.PIS = TXB_PIS.Text;
        _service.InfoAssociado.Documentos.RG.Numero = TXB_RG.Text;
        _service.InfoAssociado.Documentos.RG.DataEmisao = DTP_DataEmissao.Value;
        _service.InfoAssociado.Documentos.RG.NomePai = TXB_NomePai.Text;
        _service.InfoAssociado.Documentos.RG.NomeMae = TXB_NomeMae.Text;
        _service.InfoAssociado.Documentos.RG.OrgaoEmissor = TXB_OrgaoEmissor.Text;
        _service.InfoAssociado.Documentos.RG.EstadoEmissao = CB_EstadoEmissao.SelectedText;
        MessageBox.Show("Dados atualizados.", "Sucersso!");
        Close();
    }

    private void BTN_Cancelar_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void FRM_Documentos_Load(object sender, EventArgs e)
    {
        TXB_CPF.Text = _service.InfoAssociado.Documentos.CPF;
        TXB_PIS.Text = _service.InfoAssociado.Documentos.PIS;
        TXB_RG.Text = _service.InfoAssociado.Documentos.RG.Numero;
        DTP_DataEmissao.Value = _service.InfoAssociado.Documentos.RG.DataEmisao;
        TXB_NomePai.Text = _service.InfoAssociado.Documentos.RG.NomePai;
        TXB_NomeMae.Text = _service.InfoAssociado.Documentos.RG.NomeMae;
        TXB_OrgaoEmissor.Text = _service.InfoAssociado.Documentos.RG.OrgaoEmissor;
        CB_EstadoEmissao.SelectedText = _service.InfoAssociado.Documentos.RG.EstadoEmissao;
    }
}
