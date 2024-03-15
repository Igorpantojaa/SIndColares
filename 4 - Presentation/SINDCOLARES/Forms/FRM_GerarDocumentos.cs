using Servicos;

namespace SINDCOLARES.Forms;

public partial class FRM_GerarDocumentos : Form
{
    private readonly ICadastroService _service;
    public FRM_GerarDocumentos(ICadastroService service)
    {
        _service = service;
        InitializeComponent();
        AtualizaTabela();
        CarregaPeriodos();
    }
    private void BTN_Fechar_Click(object sender, EventArgs e)
    {
        _service.LimparCadastro();
        _service.LimpaPeriodo();
        Close();
    }
    private void BTN_VerCadastro_Click(object sender, EventArgs e)
    {
        VisualizarCadastro();
    }   
    private void CB_Vigencia_SelectionChangeCommitted(object sender, EventArgs e)
    {
        CarregaInfoVigencia();
    }
    private void DGV_Associados_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        CarregaInfoAssociado();
    }

    private int SelecaoTabela()
    {
        if (DGV_Associados.SelectedRows.Count > 0)
        {
            return Convert.ToInt32(DGV_Associados.SelectedRows[0].Cells[0].Value);
        }
        else
        {
            return 0;
        }
    }
    private void AtualizaTabela()
    {
        DGV_Associados.DataSource = _service.ListarAssociados();
    }
    private void CarregaPeriodos()
    {
        CB_Vigencia.DataSource = _service.ListarPeriodos();
    }
    private void VisualizarCadastro()
    {
        if(SelecaoTabela() > 0)
        {
            _service.Recuperar(SelecaoTabela());
            new FRM_Cadastro(_service).ShowDialog();
        }
    }
    private void CarregaInfoVigencia()
    {
        _service.RecuperarPeriodo(Convert.ToInt32(CB_Vigencia.SelectedValue));
        LBL_DataPublicacao.Text = _service.Periodo.GetDataPublicacao;
        LBL_InicioPeriodo1.Text = _service.Periodo.GetInicioVigencia1;
        LBL_FimPeriodo1.Text = _service.Periodo.GetFimVigencia1;
        LBL_InicioPeriodo2.Text = _service.Periodo.GetInicioVigencia2;
        LBL_FimPeriodo2.Text = _service.Periodo.GetFimVigencia2;
    }
    private void CarregaInfoAssociado()
    {
        if (SelecaoTabela() > 0)
        {
            _service.Recuperar(SelecaoTabela());
        }
    }
}