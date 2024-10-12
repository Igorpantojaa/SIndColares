﻿using Infraestrutura;
using Servicos;
using Spire.Doc;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
    private void TXB_Pesquisa_KeyPress(object sender, KeyPressEventArgs e)
    {
        DGV_Associados.DataSource = _service.ListarAssociados().Where(x => x.Nome.StartsWith(TXB_Pesquisa.Text)).ToList();
    }
    private void DGV_Associados_SelectionChanged(object sender, EventArgs e)
    {
        CarregaInfoAssociado();
    }
    private void CB_Vigencia_SelectionChangeCommitted(object sender, EventArgs e)
    {
        CarregaInfoVigencia();
    }
    private void DGV_Associados_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        CarregaInfoAssociado();
    }

    private bool ChecaDocs()
    {
        if (!CHB_DecResidencia.Checked
         && !CHB_Filiacao.Checked
         && !CHB_Procuracao.Checked
         && !CHB_RegInicial.Checked
         && !CHB_ReqSeguroDefeso.Checked)
        {
            Mensagens.Alerta("Selecione pelo menos um documento para gerar.", "Informacao");
            return false;
        }
        else
        {
            return true;
        }
    }
    private bool ChecaInfo()
    {
        if (_service.AssociadoTemp.Id > 0 && _service.PeriodoTemp.Id > 0)
        {
            return true;
        }
        else
        {
            Mensagens.Alerta("Selecione um associado e um período de vigência para continuar.", "Informacao");
            return false;
        }
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
    private void GeraDocumentos()
    {
        if (ChecaDocs() && ChecaInfo())
        {
            FolderBrowserDialog fbd = new();
            if (DialogResult.OK == fbd.ShowDialog())
            {
                var destino = fbd.SelectedPath;
                var data = DTP_DataDocumento.Value;
                var docs = _service.SalvaDocumentos(destino);
                if (CHB_RegInicial.Checked) docs.RegistroInicial(RB_PDF.Checked, CHB_PastaClienteSaida.Checked, data);
                if (CHB_Filiacao.Checked) docs.DeclaracaoFiliacao(RB_PDF.Checked, CHB_PastaClienteSaida.Checked, data);
                if (CHB_ReqSeguroDefeso.Checked) docs.ReqSeguroDefeso(RB_PDF.Checked, CHB_PastaClienteSaida.Checked);
                if (CHB_Procuracao.Checked) docs.Procuracao(RB_PDF.Checked, CHB_PastaClienteSaida.Checked);
                if (CHB_DecResidencia.Checked) docs.DeclaracaoResidencia(RB_PDF.Checked, CHB_PastaClienteSaida.Checked, data);
                if (CHB_AbreDestino.Checked) GestaoArquivos.AbrirPasta(destino);
                MessageBox.Show("Arquivos Gerados com sucesso!", "Sucesso");
                TXB_Pesquisa.Focus();
            };
        }
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

    private void BTN_Imprimir_Click(object sender, EventArgs e)
    {
        try
        {
            if (ChecaDocs() && ChecaInfo())
            {
                var destino = ".\\temp";
                var data = DTP_DataDocumento.Value;
                var listaDocs = new List<string>();
                var docs = _service.SalvaDocumentos(destino);
                if (CHB_RegInicial.Checked) listaDocs.Add(docs.RegistroInicial(false, CHB_PastaClienteSaida.Checked, data));
                if (CHB_Filiacao.Checked) listaDocs.Add(docs.DeclaracaoFiliacao(false, CHB_PastaClienteSaida.Checked, data));
                if (CHB_ReqSeguroDefeso.Checked) listaDocs.Add(docs.ReqSeguroDefeso(false, CHB_PastaClienteSaida.Checked));
                if (CHB_Procuracao.Checked) listaDocs.Add(docs.Procuracao(false, CHB_PastaClienteSaida.Checked));
                if (CHB_DecResidencia.Checked) listaDocs.Add(docs.DeclaracaoResidencia(false, CHB_PastaClienteSaida.Checked, data));
                MessageBox.Show("Arquivos Gerados com sucesso!", "Sucesso");
                foreach (var doc in listaDocs)
                {
                    Document documento = new( );
                    PrintPreviewDialog pd = new();
                    var print = documento.PrintDocument;
                    print.DocumentName = doc;
                    pd.Document = print;
                    pd.ShowDialog();
                }
                TXB_Pesquisa.Focus();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Erro!");
        }
    }
}