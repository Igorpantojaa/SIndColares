using Servicos;
namespace SINDCOLARES;

public partial class FRM_GestaoAssociados : Form
{
    private readonly ICadastroService _service;
    public FRM_GestaoAssociados(ICadastroService service)
    {
        _service = service;
        InitializeComponent();
    }

    private void GestaoAssociados_Load(object sender, EventArgs e)
    {
        DGV_Associados.DataSource = _service.ListarAssociados();
    }

    private int SelecaoAtual()
    {
        if (DGV_Associados.SelectedRows.Count > 0)
        {
            var selecao = Convert.ToInt32(DGV_Associados.SelectedRows[0].Cells[0].Value);
            PB_FotoAssociado.ImageLocation = _service.ImagemAssociado(selecao);
            return selecao;
        }
        else
        {
            return -1;
        }
    }

    private void BTN_Alterar_Click(object sender, EventArgs e)
    {
        if (SelecaoAtual() > 0)
        {
            _service.Recuperar(SelecaoAtual());
            new FRM_Cadastro(_service).ShowDialog();
            AtualizaTabela();
        }
    }

    private void AtualizaTabela()
    {
        DGV_Associados.DataSource = _service.ListarAssociados();
    }

    private void BTN_Fechar_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void DGV_Associados_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        SelecaoAtual();
    }

    private void BTN_Novo_Click(object sender, EventArgs e)
    {
        _service.LimparCadastro();
        new FRM_Cadastro(_service).ShowDialog();
        AtualizaTabela();
    }

    private void BTN_Excluir_Click(object sender, EventArgs e)
    {

    }
}