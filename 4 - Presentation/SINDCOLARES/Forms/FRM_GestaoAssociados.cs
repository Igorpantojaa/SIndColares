using Servicos;
using SINDCOLARES.Formularios;
namespace SINDCOLARES;

public partial class FRM_GestaoAssociados : Form
{
    private readonly ICadastroService _service;
    public FRM_GestaoAssociados(ICadastroService service)
    {
        _service = service;
        InitializeComponent();
    }
    private void BTN_Novo_Click(object sender, EventArgs e)
    {
        _service.LimparCadastro();
        new FRM_Cadastro(_service).ShowDialog();
        AtualizaTabela();
    }
    private void BTN_Fechar_Click(object sender, EventArgs e)
    {
        Close();
    }
    private void BTN_Excluir_Click(object sender, EventArgs e)
    {
        try
        {
            if (SelecaoAtual() > 0)
            {
                _service.Recuperar(SelecaoAtual());
                if (DialogResult.Yes == MessageBox.Show
                                        (
                                            "Deseja realmente excluir o registro selecionado?",
                                            "Atenção",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question
                                        )
                    )
                {
                    _service.Excluir(SelecaoAtual());
                }
                AtualizaTabela();
            }
        }
        catch (Exception ex)
        {
            Mensagens.Alerta($"Houve um problema ao escluir o registro:\n{ex.Message}", "Erro");
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
    private void GestaoAssociados_Load(object sender, EventArgs e)
    {
        DGV_Associados.DataSource = _service.ListarAssociados();
    }
    private void DGV_Associados_SelectionChanged(object sender, EventArgs e)
    {
        SelecaoAtual();
    }
    private void DGV_Associados_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        SelecaoAtual();
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
    private void AtualizaTabela()
    {
        DGV_Associados.DataSource = _service.ListarAssociados();
    }

    private void BTN_LimpaPesquisa_Click(object sender, EventArgs e)
    {
        AtualizaTabela();
    }

    private void TXB_Pesquisa_KeyPress(object sender, KeyPressEventArgs e)
    {
        DGV_Associados.DataSource = _service.ListarAssociados()
            .Where(x => x.Nome.StartsWith(TXB_Pesquisa.Text)).ToList();
    }
}