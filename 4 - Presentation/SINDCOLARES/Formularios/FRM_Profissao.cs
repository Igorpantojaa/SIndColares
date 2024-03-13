using Servicos;
using Servicos.ComboBox;

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
        Mensages.Alerta("Dados atualizados.", "Sucesso!");
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

    private void SalvarInformacoes()
    {
        _service.InfoAssociado.Profissao.AB = TXB_AB.Text;
        _service.InfoAssociado.Profissao.RGP = TXB_RGP.Text;
        _service.InfoAssociado.Documentos.CEI = TXB_CEI.Text;
        _service.InfoAssociado.Profissao.AreaPesca = CB_AreaPesca.Text;
        _service.InfoAssociado.Profissao.FormaPesca = CB_FormaPesca.Text;
        _service.InfoAssociado.Profissao.LocalPesca = TXB_LocalPesca.Text;
        _service.InfoAssociado.Profissao.Empregado = CHB_Empregado.Checked;
        _service.InfoAssociado.Profissao.Aposentado = CHB_Aposentado.Checked;
        _service.InfoAssociado.Profissao.ProdutoPesca.Algas = CHB_Algas.Checked;
        _service.InfoAssociado.Profissao.ProdutoPesca.Peixes = CHB_Peixes.Checked;
        _service.InfoAssociado.Profissao.ProdutoPesca.Outros = CHB_Outros.Checked;
        _service.InfoAssociado.Profissao.NomeEmbarcacao = TXB_NomeEmbarcacao.Text;
        _service.InfoAssociado.Profissao.Categoria = CB_CategoriaProfissional.Text;
        _service.InfoAssociado.Profissao.CPFProprietario = TXB_CPFProprietario.Text;
        _service.InfoAssociado.Profissao.ProdutoPesca.Mariscos = CHB_Mariscos.Checked;
        _service.InfoAssociado.Profissao.ProdutoPesca.Crustaceos = CHB_Crustaceos.Checked;
    }
    private void CarregarInformacoes()
    {
        TXB_AB.Text = _service.InfoAssociado.Profissao.AB;
        TXB_RGP.Text = _service.InfoAssociado.Profissao.RGP;
        TXB_CEI.Text = _service.InfoAssociado.Documentos.CEI;
        CB_AreaPesca.Text = _service.InfoAssociado.Profissao.AreaPesca;
        CB_FormaPesca.Text = _service.InfoAssociado.Profissao.FormaPesca;
        CHB_Empregado.Checked = _service.InfoAssociado.Profissao.Empregado;
        CHB_Aposentado.Checked = _service.InfoAssociado.Profissao.Aposentado;
        CHB_Algas.Checked = _service.InfoAssociado.Profissao.ProdutoPesca.Algas;
        TXB_NomeEmbarcacao.Text = _service.InfoAssociado.Profissao.NomeEmbarcacao;
        CHB_Peixes.Checked = _service.InfoAssociado.Profissao.ProdutoPesca.Peixes;
        CHB_Outros.Checked = _service.InfoAssociado.Profissao.ProdutoPesca.Outros;
        CB_CategoriaProfissional.Text = _service.InfoAssociado.Profissao.Categoria;
        TXB_CPFProprietario.Text = _service.InfoAssociado.Profissao.CPFProprietario;
        CHB_Mariscos.Checked = _service.InfoAssociado.Profissao.ProdutoPesca.Mariscos;
        CHB_Crustaceos.Checked = _service.InfoAssociado.Profissao.ProdutoPesca.Crustaceos;
    }
}