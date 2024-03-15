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
    private int SelecaoTabela()
    {
        if(DGV_Associados.SelectedRows.Count > 0)
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
    private void CarregaInfoAssociado()
    {
        if(SelecaoTabela() > 0)
        {
            _service.Recuperar(SelecaoTabela());
        }
    }
    private void CarregaPeriodos()
    {
        CB_Vigencia.DataSource = _service.ListarPeriodos();
    }
}
