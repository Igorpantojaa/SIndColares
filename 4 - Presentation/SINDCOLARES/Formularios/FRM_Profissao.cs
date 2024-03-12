using Servicos;

namespace SINDCOLARES.Formularios;

public partial class FRM_Profissao : Form
{
    private readonly ICadastroService _service;
    public FRM_Profissao(ICadastroService service)
    {
        _service = service;
        InitializeComponent();
    }

    private void BTN_Salvar_Click(object sender, EventArgs e)
    {
        _service.InfoAssociado.Profissao.LocalPesca = CB_AreaPesca.SelectedText;
        _service.InfoAssociado.Profissao.FormaPesca = CB_FormaPesca.SelectedText;
        _service.InfoAssociado.Profissao.Categoria = CB_CategoriaProfissional.SelectedText;
        _service.InfoAssociado.Profissao.NomeEmbarcacao = TXB_NomeEmbarcacao.Text;
        _service.InfoAssociado.Profissao.AB = TXB_AB.Text;
        _service.InfoAssociado.Profissao.RGP = TXB_RGP.Text;
        if (CHB_Aposentado.Checked == true)
        {
            _service.InfoAssociado.Profissao.Aposentado = true;
        }
        else
        {
            _service.InfoAssociado.Profissao.Aposentado = false;
        }
        if (CHB_Empregado.Checked == true)
        {
            _service.InfoAssociado.Profissao.Empregado = true;
        }
        else
        {
            _service.InfoAssociado.Profissao.Empregado = false;
        }
        MessageBox.Show("Dados atualizados.", "Sucersso!");
        Close();
    }
    private void BTN_Cancelar_Click(object sender, EventArgs e)
    {
        Close();
    }
    private void FRM_Profissao_Load(object sender, EventArgs e)
    {
        CB_AreaPesca.SelectedText = _service.InfoAssociado.Profissao.LocalPesca;
        CB_FormaPesca.SelectedText = _service.InfoAssociado.Profissao.FormaPesca;
        CB_CategoriaProfissional.SelectedText = _service.InfoAssociado.Profissao.Categoria;
        TXB_NomeEmbarcacao.Text = _service.InfoAssociado.Profissao.NomeEmbarcacao;
        TXB_AB.Text = _service.InfoAssociado.Profissao.AB;
        TXB_RGP.Text = _service.InfoAssociado.Profissao.RGP;
        CHB_Empregado.Checked = _service.InfoAssociado.Profissao.Empregado;
        CHB_Aposentado.Checked = _service.InfoAssociado.Profissao.Aposentado;
    }
}
