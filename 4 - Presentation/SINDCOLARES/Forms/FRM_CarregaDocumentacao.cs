using Servicos;
using Infraestrutura;
using System.Diagnostics;
using SINDCOLARES.Forms;

namespace SINDCOLARES.Formularios;

public partial class FRM_CarregaDocumentacao : Form
{
    private readonly ICadastroService _service;
    private readonly string _local;

    public FRM_CarregaDocumentacao(ICadastroService service)
    {
        _service = service;
        _local = _service.AssociadoTemp.Digitalizados.Local;
        InitializeComponent();
        ChecaDocumentacao();
    }

    private void BTN_Voltar_Click(object sender, EventArgs e)
    {
        Close();
    }
    private void BTN_SelecionaRG_Click(object sender, EventArgs e)
    {
        var destino = $"{_local}\\RG.pdf";
        SalvarArquivo(destino);
        _service.AssociadoTemp.Digitalizados.RG = destino;
        ChecaDocumentacao();
    }
    private void BTN_SelecionaCPF_Click(object sender, EventArgs e)
    {
        var destino = $"{_local}\\CPF.pdf";
        SalvarArquivo(destino);
        _service.AssociadoTemp.Digitalizados.CPF = destino;
        ChecaDocumentacao();
    }
    private void BTN_SelecionaReqINSS_Click(object sender, EventArgs e)
    {
        var destino = $"{_local}\\REQUERIMENTO_INSS [{_service.PeriodoTemp.AnoVigencia}].pdf";
        SalvarArquivo(destino);
        _service.AssociadoTemp.Digitalizados.ReqINSS = destino;
        ChecaDocumentacao();
    }
    private void BTN_SelecionaFiliacao_Click(object sender, EventArgs e)
    {
        var destino = $"{_local}\\DECLARACAO_DE_FILIACAO.pdf";
        SalvarArquivo(destino);
        _service.AssociadoTemp.Digitalizados.Filiacao = destino;
        ChecaDocumentacao();
    }
    private void BTN_SelecionaRegInicial_Click(object sender, EventArgs e)
    {
        var destino = $"{_local}\\REQUERIMENTO_DE_LICENSA.pdf";
        SalvarArquivo(destino);
        _service.AssociadoTemp.Digitalizados.RegInicial = destino;
        ChecaDocumentacao();
    }
    private void BTN_SelecionaResidencia_Click(object sender, EventArgs e)
    {
        var destino = $"{_local}\\COMPROVANTE_DE_RESIDENCIA.pdf";
        SalvarArquivo(destino);
        _service.AssociadoTemp.Digitalizados.Residencia = destino;
        ChecaDocumentacao();
    }
    private void BTN_SelecionaProcuracao_Click(object sender, EventArgs e)
    {
        var destino = $"{_local}\\TERMO_DE_AUTORIZACAO.pdf";
        SalvarArquivo(destino);
        _service.AssociadoTemp.Digitalizados.Procuracao = destino;
        ChecaDocumentacao();
    }
    private void BTN_SelecionaCanhotoProtocolo_Click(object sender, EventArgs e)
    {
        var destino = $"{_local}\\CANHOTO_PROTOCOLO [{_service.PeriodoTemp.AnoVigencia}].pdf";
        SalvarArquivo(destino);
        _service.AssociadoTemp.Digitalizados.CanhotoProtocolo = destino;
        ChecaDocumentacao();
    }

    private void BTN_AbrirPasta_Click(object sender, EventArgs e)
    {
        GestaoArquivos.AbrirPasta(_local);
    }
    private void BTN_VisualizaRG_Click(object sender, EventArgs e)
    {
        AbrirArquivo(_service.AssociadoTemp.Digitalizados.RG);
    }
    private void BTN_VisualizaCPF_Click(object sender, EventArgs e)
    {
        AbrirArquivo(_service.AssociadoTemp.Digitalizados.CPF);
    }
    private void BTN_VisualizaReqINSS_Click(object sender, EventArgs e)
    {
        AbrirArquivo(_service.AssociadoTemp.Digitalizados.ReqINSS);
    }
    private void BTN_VisualizaFiliacao_Click(object sender, EventArgs e)
    {
        AbrirArquivo(_service.AssociadoTemp.Digitalizados.Filiacao);
    }
    private void BTN_VisualizaReqLicensa_Click(object sender, EventArgs e)
    {
        AbrirArquivo(_service.AssociadoTemp.Digitalizados.RegInicial);
    }
    private void BTN_VisualizaResidencia_Click(object sender, EventArgs e)
    {
        AbrirArquivo(_service.AssociadoTemp.Digitalizados.Residencia);
    }
    private void BTN_VisualizaTermoAutorizacao_Click(object sender, EventArgs e)
    {
        AbrirArquivo(_service.AssociadoTemp.Digitalizados.Procuracao);
    }
    private void BTN_VisualizaCanhotoProtocolo_Click(object sender, EventArgs e)
    {
        AbrirArquivo(_service.AssociadoTemp.Digitalizados.CanhotoProtocolo);
    }

    private void BTN_ExcluirRG_Click(object sender, EventArgs e)
    {
        _service.AssociadoTemp.Digitalizados.RG = 
            ExcluirArquivo(_service.AssociadoTemp.Digitalizados.RG);
        ChecaDocumentacao();
    }
    private void BTN_ExcluirCPF_Click(object sender, EventArgs e)
    {
        _service.AssociadoTemp.Digitalizados.CPF = 
            ExcluirArquivo(_service.AssociadoTemp.Digitalizados.CPF);
        ChecaDocumentacao();
    }
    private void BTN_ExcluirReqINSS_Click(object sender, EventArgs e)
    {
        _service.AssociadoTemp.Digitalizados.ReqINSS = 
            ExcluirArquivo(_service.AssociadoTemp.Digitalizados.ReqINSS);
        ChecaDocumentacao();
    }
    private void BTN_ExcluirFiliacao_Click(object sender, EventArgs e)
    {
        _service.AssociadoTemp.Digitalizados.Filiacao = 
            ExcluirArquivo(_service.AssociadoTemp.Digitalizados.Filiacao);
        ChecaDocumentacao();
    }
    private void BTN_ExcluirReqLicensa_Click(object sender, EventArgs e)
    {
        _service.AssociadoTemp.Digitalizados.RegInicial = 
            ExcluirArquivo(_service.AssociadoTemp.Digitalizados.RegInicial);
        ChecaDocumentacao();
    }
    private void BTN_ExcluirResidencia_Click(object sender, EventArgs e)
    {
        _service.AssociadoTemp.Digitalizados.Residencia = 
            ExcluirArquivo(_service.AssociadoTemp.Digitalizados.Residencia);
        ChecaDocumentacao();
    }
    private void BTN_ExcluirAutorizacao_Click(object sender, EventArgs e)
    {
        _service.AssociadoTemp.Digitalizados.Procuracao =
            ExcluirArquivo(_service.AssociadoTemp.Digitalizados.Procuracao);
        ChecaDocumentacao();
    }
    private void BTN_ExcluirCanhotoProtocolo_Click(object sender, EventArgs e)
    {
        _service.AssociadoTemp.Digitalizados.CanhotoProtocolo = 
            ExcluirArquivo(_service.AssociadoTemp.Digitalizados.CanhotoProtocolo);
        ChecaDocumentacao();
    }

    private void ChecaDocumentacao()
    {
        if (_service.AssociadoTemp.Digitalizados.CPFCarregado == true)
        {
            BTN_SelecionaCPF.BackColor = Color.LightGreen;
            BTN_SelecionaCPF.Enabled = false;
        }
        else
        {
            BTN_SelecionaCPF.BackColor = SystemColors.ButtonHighlight;
            BTN_SelecionaCPF.Enabled = true;
            _service.AssociadoTemp.Digitalizados.CPF = string.Empty;
        }

        if (_service.AssociadoTemp.Digitalizados.RGCarregado == true)
        {
            BTN_SelecionaRG.BackColor = Color.LightGreen;
            BTN_SelecionaRG.Enabled = false;
        }
        else
        {
            BTN_SelecionaRG.BackColor = SystemColors.ButtonHighlight;
            BTN_SelecionaRG.Enabled= true;
            _service.AssociadoTemp.Digitalizados.RG = string.Empty;
        }

        if (_service.AssociadoTemp.Digitalizados.FiliacaoCarregado == true)
        {
            BTN_SelecionaFiliacao.BackColor = Color.LightGreen;
            BTN_SelecionaFiliacao.Enabled = false;
        }
        else
        {
            BTN_SelecionaFiliacao.BackColor = SystemColors.ButtonHighlight;
            BTN_SelecionaFiliacao.Enabled = true;
            _service.AssociadoTemp.Digitalizados.Filiacao = string.Empty;
        }

        if (_service.AssociadoTemp.Digitalizados.ResidenciaCarregado == true)
        {
            BTN_SelecionaResidencia.BackColor = Color.LightGreen;
            BTN_SelecionaResidencia.Enabled = false;
        }
        else
        {
            BTN_SelecionaResidencia.BackColor = SystemColors.ButtonHighlight;
            BTN_SelecionaResidencia.Enabled= true;
            _service.AssociadoTemp.Digitalizados.Residencia = string.Empty;
        }

        if (_service.AssociadoTemp.Digitalizados.ProcuracaoCarregado == true)
        {
            BTN_SelecionaProcuracao.BackColor = Color.LightGreen;
            BTN_SelecionaProcuracao.Enabled = false;
        }
        else
        {
            BTN_SelecionaProcuracao.BackColor = SystemColors.ButtonHighlight;
            BTN_SelecionaProcuracao.Enabled= true;
            _service.AssociadoTemp.Digitalizados.Procuracao = string.Empty;
        }

        if (_service.AssociadoTemp.Digitalizados.ReqInicialCarregado == true)
        {
            BTN_SelecionaRegInicial.BackColor = Color.LightGreen;
            BTN_SelecionaRegInicial.Enabled = false;
        }
        else
        {
            BTN_SelecionaRegInicial.BackColor = SystemColors.ButtonHighlight;
            BTN_SelecionaRegInicial.Enabled= true;
            _service.AssociadoTemp.Digitalizados.RegInicial = string.Empty;
        }

        if (_service.AssociadoTemp.Digitalizados.ReqINSSCarregado == true)
        {
            BTN_SelecionaReqINSS.BackColor = Color.LightGreen;
            BTN_SelecionaReqINSS.Enabled = false;
        }
        else
        {
            BTN_SelecionaReqINSS.BackColor = SystemColors.ButtonHighlight;
            BTN_SelecionaReqINSS.Enabled= true;
            _service.AssociadoTemp.Digitalizados.ReqINSS = string.Empty;
        }

        if (_service.AssociadoTemp.Digitalizados.CanhotoProtocoloCarregado == true)
        {
            BTN_SelecionaCanhotoProtocolo.BackColor = Color.LightGreen;
            BTN_SelecionaCanhotoProtocolo.Enabled = false;
        }
        else
        {
            BTN_SelecionaCanhotoProtocolo.BackColor = SystemColors.ButtonHighlight;
            BTN_SelecionaCanhotoProtocolo.Enabled= true;
            _service.AssociadoTemp.Digitalizados.CanhotoProtocolo = string.Empty;
        }
    }
    private static void AbrirArquivo(string caminho)
    {
        if (File.Exists(caminho))
        {
            Process.Start("explorer.exe", caminho);
        }
        else
        {
            MessageBox.Show
            (
                "Houve um problema ao procurar o arquivo.\nVerifiqu se o arquivo foi salvo corretamente.",
                "Erro!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }
    }
    private static void SalvarArquivo(string destino)
    {
        try
        {
            OpenFileDialog ofd = new()
            {
                Filter = "Arquivos PDF (*.pdf)|*.pdf"
            };
            if (DialogResult.OK == ofd.ShowDialog())
            {
                if (!File.Exists(destino))
                {
                    GestaoArquivos.SalvarArquivo(ofd.FileName, destino);
                    Mensagens.Alerta("Arquivo salvo com sucesso!", "Informacao");
                }
                else
                {
                    if (Mensagens.Sobrecresver())
                    {
                        GestaoArquivos.SalvarArquivo(ofd.FileName, destino);
                        Mensagens.Alerta("Arquivo substituido com sucesso!", "Informacao");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show
            (
                ex.Message,
                "Erro!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }
    }
    private static string ExcluirArquivo(string caminho)
    {
        try
        {
            if (Mensagens.Exclusao())
            {
                GestaoArquivos.ExcluirArquivo(caminho);
                Mensagens.Alerta("Arquivo excluído com sucesso!", "Informacao");
                return string.Empty;
            }
            else { return caminho; }
        }
        catch (Exception ex)
        {
            MessageBox.Show
            (
                $"Ocorreu um erro ao excluir o arquivo: {ex.Message}",
                "Erro!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return caminho;
        }
    }
}