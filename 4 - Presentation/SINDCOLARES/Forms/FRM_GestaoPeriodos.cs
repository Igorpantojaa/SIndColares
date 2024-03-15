using Servicos;

namespace SINDCOLARES.Formularios;

public partial class FRM_GestaoPeriodos : Form
{
    private readonly ICadastroService _service;
    public FRM_GestaoPeriodos(ICadastroService service)
    {
        _service = service;
        InitializeComponent();
        AtualizaTabela();
    }


    private void BTN_Novo_Click(object sender, EventArgs e)
    {
        new FRM_CadastraPeriodo(_service).ShowDialog();
        AtualizaTabela();
    }
    private void BTN_Fechar_Click(object sender, EventArgs e)
    {
        Close();
    }
    private void BTN_Excluir_Click(object sender, EventArgs e)
    {
        ExcluirPeriodo();
        AtualizaTabela();
    }
    private void BTN_Alterar_Click(object sender, EventArgs e)
    {
        AlterarPeriodo();
        AtualizaTabela();
    }

    private void AtualizaTabela()
    {
        DGV_Periodos.DataSource = _service.ListarPeriodos();
    }
    private void ExcluirPeriodo()
    {
        try
        {
            if (SelecaoAtual() != 0 && DialogResult.Yes == MessageBox.Show
                                                            (
                                                                "Deseja remover o período selecionado?",
                                                                "Atenção",
                                                                MessageBoxButtons.YesNo,
                                                                MessageBoxIcon.Question)
                                                            )
            {
                _service.RecuperarPeriodo(SelecaoAtual());
                _service.ExcluirPeriodo();
                Mensagens.Alerta("Período excluido com sucesso!", "Informacao");
            }
        }
        catch (Exception ex)
        {
            Mensagens.Alerta($"Problema ao excluir registro\n{ex.Message}", "Erro");
        }
    }
    private void AlterarPeriodo()
    {
        try
        {
            if(SelecaoAtual() != 0)
            {
                _service.LimpaPeriodo();
                _service.RecuperarPeriodo(SelecaoAtual());
                new FRM_CadastraPeriodo(_service).ShowDialog();
            }
        }
        catch(Exception ex)
        {
            Mensagens.Alerta($"Houve um erro ao recuperar o registro selecionado\n{ex.Message}", "Erro");
        }
    }
    private int SelecaoAtual()
    {
        if (DGV_Periodos.SelectedRows.Count > 0)
        {
            return Convert.ToInt32(DGV_Periodos.SelectedRows[0].Cells[0].Value);
        }
        else
        {
            return 0;
        }
    }
}