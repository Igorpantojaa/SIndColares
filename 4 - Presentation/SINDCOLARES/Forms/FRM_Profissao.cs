using Servicos;
using Servicos.ComboBox;
using Servicos.Utilidades;
using SINDCOLARES.Forms;

namespace SINDCOLARES.Formularios;

public partial class FRM_Profissao : Form
{
    private readonly ICadastroService _service;
    public FRM_Profissao(ICadastroService service)
    {
        _service = service;
        InitializeComponent();
        CB_AreaPesca.DataSource = ConteudoComboBox.AreaPesca();
        CB_FormaPesca.DataSource = ConteudoComboBox.FormaPesca();
        CB_CategoriaProfissional.DataSource = ConteudoComboBox.CategoriaProfissional();
    }

    private void BTN_Salvar_Click(object sender, EventArgs e)
    {
        SalvarInformacoes();
        Mensagens.Alerta("Dados atualizados.", "Sucesso!");
        Close();
    }
    private void BTN_Cancelar_Click(object sender, EventArgs e)
    {
        Close();
    }
    private void FRM_Profissao_Load(object sender, EventArgs e)
    {
        CarregarInformacoes();
    }
    private void TXB_CEI_Leave(object sender, EventArgs e)
    {
        TXB_CEI.Text = CEI.FormataCEI(TXB_CEI.Text);
    }

    private void SalvarInformacoes()
    {
        _service.AssociadoTemp.Profissao.AB = TXB_AB.Text;
        _service.AssociadoTemp.Profissao.RGP = TXB_RGP.Text;
        _service.AssociadoTemp.Documentos.CEI = TXB_CEI.Text;
        _service.AssociadoTemp.Profissao.AreaPesca = CB_AreaPesca.Text;
        _service.AssociadoTemp.Profissao.FormaPesca = CB_FormaPesca.Text;
        _service.AssociadoTemp.Profissao.LocalPesca = TXB_LocalPesca.Text;
        _service.AssociadoTemp.Profissao.Empregado = CHB_Empregado.Checked;
        _service.AssociadoTemp.Profissao.Aposentado = CHB_Aposentado.Checked;
        _service.AssociadoTemp.Profissao.ProdutoPesca.Algas = CHB_Algas.Checked;
        _service.AssociadoTemp.Profissao.ProdutoPesca.Peixes = CHB_Peixes.Checked;
        _service.AssociadoTemp.Profissao.ProdutoPesca.Outros = CHB_Outros.Checked;
        _service.AssociadoTemp.Profissao.NomeEmbarcacao = TXB_NomeEmbarcacao.Text;
        _service.AssociadoTemp.Profissao.Categoria = CB_CategoriaProfissional.Text;
        _service.AssociadoTemp.Profissao.CPFProprietario = TXB_CPFProprietario.Text;
        _service.AssociadoTemp.Profissao.ProdutoPesca.Mariscos = CHB_Mariscos.Checked;
        _service.AssociadoTemp.Profissao.ProdutoPesca.Crustaceos = CHB_Crustaceos.Checked;
    }
    private void CarregarInformacoes()
    {
        TXB_AB.Text = _service.AssociadoTemp.Profissao.AB;
        TXB_RGP.Text = _service.AssociadoTemp.Profissao.RGP;
        TXB_CEI.Text = _service.AssociadoTemp.Documentos.CEI;
        CB_AreaPesca.Text = _service.AssociadoTemp.Profissao.AreaPesca;
        CB_FormaPesca.Text = _service.AssociadoTemp.Profissao.FormaPesca;
        CHB_Empregado.Checked = _service.AssociadoTemp.Profissao.Empregado;
        CHB_Aposentado.Checked = _service.AssociadoTemp.Profissao.Aposentado;
        CHB_Algas.Checked = _service.AssociadoTemp.Profissao.ProdutoPesca.Algas;
        TXB_NomeEmbarcacao.Text = _service.AssociadoTemp.Profissao.NomeEmbarcacao;
        CHB_Peixes.Checked = _service.AssociadoTemp.Profissao.ProdutoPesca.Peixes;
        CHB_Outros.Checked = _service.AssociadoTemp.Profissao.ProdutoPesca.Outros;
        CB_CategoriaProfissional.Text = _service.AssociadoTemp.Profissao.Categoria;
        TXB_CPFProprietario.Text = _service.AssociadoTemp.Profissao.CPFProprietario;
        CHB_Mariscos.Checked = _service.AssociadoTemp.Profissao.ProdutoPesca.Mariscos;
        CHB_Crustaceos.Checked = _service.AssociadoTemp.Profissao.ProdutoPesca.Crustaceos;
    }
}