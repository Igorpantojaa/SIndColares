using Infraestrutura;
using Servicos;
using SINDCOLARES.Formularios;

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
        _service.LimparPeriodo();
        Close();
    }
    private void BTN_VerCadastro_Click(object sender, EventArgs e)
    {
        VisualizarCadastro();
    }
    private void BTN_GeraDocumentos_Click(object sender, EventArgs e)
    {
        GeraDocumentos();
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
        CB_Vigencia.DataSource = _service.PeriodoService.ListarTodos();
        CB_Vigencia.SelectedIndex = -1;
    }
    private void VisualizarCadastro()
    {
        if (SelecaoTabela() > 0)
        {
            _service.Recuperar(SelecaoTabela());
            new FRM_Cadastro(_service).ShowDialog();
        }
    }
    private void CarregaInfoVigencia()
    {
        if (CB_Vigencia.SelectedIndex != -1)
        {
            _service.PeriodoTemp = _service.PeriodoService.Recuperar(Convert.ToInt32(CB_Vigencia.SelectedValue));
            CB_Vigencia.SelectedValue = _service.PeriodoTemp.Id;
            LBL_NumPublicacao.Text = _service.PeriodoTemp.NumeroPublicacao;
            LBL_DataPublicacao.Text = _service.PeriodoTemp.GetDataPublicacao;
            LBL_InicioPeriodo1.Text = _service.PeriodoTemp.GetInicioVigencia1;
            LBL_FimPeriodo1.Text = _service.PeriodoTemp.GetFimVigencia1;
            LBL_InicioPeriodo2.Text = _service.PeriodoTemp.GetInicioVigencia2;
            LBL_FimPeriodo2.Text = _service.PeriodoTemp.GetFimVigencia2;
        };
    }
    private void CarregaInfoAssociado()
    {
        if (SelecaoTabela() > 0)
        {
            _service.Recuperar(SelecaoTabela());
        }
    }

    private void GeraDocumentos()
    {
        if (_service.AssociadoTemp.Id > 0 && _service.PeriodoTemp.Id > 0)
        {
            FolderBrowserDialog fbd = new();
            if (DialogResult.OK == fbd.ShowDialog())
            {
                var destino = fbd.SelectedPath;
                var docs = _service.SalvaDocumentos(destino);
                if (CHB_RegInicial.Checked) docs.RegistroInicial();
                if (CHB_Filiacao.Checked) docs.DeclaracaoFiliacao();
                if (CHB_ReqSeguroDefeso.Checked) docs.ReqSeguroDefeso();
                //if (CHB_DecResidencia.Checked) docs.DeclaracaoResidencia();
                GestaoArquivos.AbrirPasta(destino);
            };
        }
        else
        {
            Mensagens.Alerta("Selecione um associado e um período de vigência para continuar.", "Informacao");
        }
    }

    private void TXB_Pesquisa_KeyPress(object sender, KeyPressEventArgs e)
    {
        DGV_Associados.DataSource = _service.ListarAssociados().Where(x => x.Nome.StartsWith(TXB_Pesquisa.Text)).ToList();
    }
}