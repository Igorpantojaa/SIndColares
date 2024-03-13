using Servicos;
using Servicos.Utilidades;
using System.Diagnostics;

namespace SINDCOLARES.Formularios;

public partial class FRM_CarregaDocumentacao : Form
{
    private readonly ICadastroService _service;
    private readonly string _local;

    public FRM_CarregaDocumentacao(ICadastroService service)
    {
        _service = service;
        _local = _service.InfoAssociado.Digitalizados.Local;
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
        _service.InfoAssociado.Digitalizados.RG = SalvarArquivo(destino);
        ChecaDocumentacao();
    }
    private void BTN_SelecionaCPF_Click(object sender, EventArgs e)
    {
        var destino = $"{_local}\\CPF.pdf";
        _service.InfoAssociado.Digitalizados.CPF = SalvarArquivo(destino);
        ChecaDocumentacao();
    }
    private void BTN_SelecionaReqINSS_Click(object sender, EventArgs e)
    {
        var destino = $"{_local}\\REQUERIMENTO_INSS.pdf";
        _service.InfoAssociado.Digitalizados.ReqINSS = SalvarArquivo(destino);
        ChecaDocumentacao();
    }
    private void BTN_SelecionaFiliacao_Click(object sender, EventArgs e)
    {
        var destino = $"{_local}\\DECLARACAO_DE_FILIACAO.pdf";
        _service.InfoAssociado.Digitalizados.Filiacao = SalvarArquivo(destino);
        ChecaDocumentacao();
    }
    private void BTN_SelecionaReqLicensa_Click(object sender, EventArgs e)
    {
        var destino = $"{_local}\\REQUERIMENTO_DE_LICENSA.pdf";
        _service.InfoAssociado.Digitalizados.ReqLicensa = SalvarArquivo(destino);
        ChecaDocumentacao();
    }
    private void BTN_SelecionaResidencia_Click(object sender, EventArgs e)
    {
        var destino = $"{_local}\\COMPROVANTE_DE_RESIDENCIA.pdf";
        _service.InfoAssociado.Digitalizados.Residencia = SalvarArquivo(destino);
        ChecaDocumentacao();
    }
    private void BTN_SelecionaTermoAutorizacao_Click(object sender, EventArgs e)
    {
        var destino = $"{_local}\\TERMO_DE_AUTORIZACAO.pdf";
        _service.InfoAssociado.Digitalizados.Autorizacao = SalvarArquivo(destino);
        ChecaDocumentacao();
    }
    private void BTN_SelecionaCanhotoProtocolo_Click(object sender, EventArgs e)
    {
        var destino = $"{_local}\\CANHOTO_PROTOCOLO.pdf";
        _service.InfoAssociado.Digitalizados.CanhotoProtocolo = SalvarArquivo(destino);
        ChecaDocumentacao();
    }

    private void BTN_AbrirPasta_Click(object sender, EventArgs e)
    {
        AbrirPasta(_local);
    }
    private void BTN_VisualizaRG_Click(object sender, EventArgs e)
    {
        AbrirArquivo(_service.InfoAssociado.Digitalizados.RG);
    }
    private void BTN_VisualizaCPF_Click(object sender, EventArgs e)
    {
        AbrirArquivo(_service.InfoAssociado.Digitalizados.CPF);
    }
    private void BTN_VisualizaReqINSS_Click(object sender, EventArgs e)
    {
        AbrirArquivo(_service.InfoAssociado.Digitalizados.ReqINSS);
    }
    private void BTN_VisualizaFiliacao_Click(object sender, EventArgs e)
    {
        AbrirArquivo(_service.InfoAssociado.Digitalizados.Filiacao);
    }
    private void BTN_VisualizaReqLicensa_Click(object sender, EventArgs e)
    {
        AbrirArquivo(_service.InfoAssociado.Digitalizados.ReqLicensa);
    }
    private void BTN_VisualizaResidencia_Click(object sender, EventArgs e)
    {
        AbrirArquivo(_service.InfoAssociado.Digitalizados.Residencia);
    }
    private void BTN_VisualizaTermoAutorizacao_Click(object sender, EventArgs e)
    {
        AbrirArquivo(_service.InfoAssociado.Digitalizados.Autorizacao);
    }
    private void BTN_VisualizaCanhotoProtocolo_Click(object sender, EventArgs e)
    {
        AbrirArquivo(_service.InfoAssociado.Digitalizados.CanhotoProtocolo);
    }


    private void BTN_ExcluirRG_Click(object sender, EventArgs e)
    {
        var caminho = _service.InfoAssociado.Digitalizados.RG;
        _service.InfoAssociado.Digitalizados.RG = ExcluirArquivo(caminho);
        ChecaDocumentacao();
    }
    private void BTN_ExcluirCPF_Click(object sender, EventArgs e)
    {
        var caminho = _service.InfoAssociado.Digitalizados.CPF;
        _service.InfoAssociado.Digitalizados.CPF = ExcluirArquivo(caminho);
        ChecaDocumentacao();
    }
    private void BTN_ExcluirReqINSS_Click(object sender, EventArgs e)
    {
        var caminho = _service.InfoAssociado.Digitalizados.ReqINSS;
        _service.InfoAssociado.Digitalizados.ReqINSS = ExcluirArquivo(caminho);
        ChecaDocumentacao();
    }
    private void BTN_ExcluirFiliacao_Click(object sender, EventArgs e)
    {
        var caminho = _service.InfoAssociado.Digitalizados.Filiacao;
        _service.InfoAssociado.Digitalizados.Filiacao = ExcluirArquivo(caminho);
        ChecaDocumentacao();
    }
    private void BTN_ExcluirReqLicensa_Click(object sender, EventArgs e)
    {
        var caminho = _service.InfoAssociado.Digitalizados.ReqLicensa;
        _service.InfoAssociado.Digitalizados.ReqLicensa = ExcluirArquivo(caminho);
        ChecaDocumentacao();
    }
    private void BTN_ExcluirResidencia_Click(object sender, EventArgs e)
    {
        var caminho = _service.InfoAssociado.Digitalizados.Residencia;
        _service.InfoAssociado.Digitalizados.Residencia = ExcluirArquivo(caminho);
        ChecaDocumentacao();
    }
    private void BTN_ExcluirAutorizacao_Click(object sender, EventArgs e)
    {
        var caminho = _service.InfoAssociado.Digitalizados.Autorizacao;
        _service.InfoAssociado.Digitalizados.Autorizacao = ExcluirArquivo(caminho);
        ChecaDocumentacao();
    }
    private void BTN_ExcluirCanhotoProtocolo_Click(object sender, EventArgs e)
    {
        var caminho = _service.InfoAssociado.Digitalizados.CanhotoProtocolo;
        _service.InfoAssociado.Digitalizados.CanhotoProtocolo = ExcluirArquivo(caminho);
        ChecaDocumentacao();
    }

    private void ChecaDocumentacao()
    {
        if (_service.InfoAssociado.Digitalizados.CPFCarregado == true)
        {
            BTN_SelecionaCPF.BackColor = Color.LightGreen;
        }
        else
        {
            BTN_SelecionaCPF.BackColor = SystemColors.ButtonHighlight;
        }

        if (_service.InfoAssociado.Digitalizados.RGCarregado == true)
        {
            BTN_SelecionaRG.BackColor = Color.LightGreen;
        }
        else
        {
            BTN_SelecionaRG.BackColor = SystemColors.ButtonHighlight;
        }

        if (_service.InfoAssociado.Digitalizados.FiliacaoCarregado == true)
        {
            BTN_SelecionaFiliacao.BackColor = Color.LightGreen;
        }
        else
        {
            BTN_SelecionaFiliacao.BackColor = SystemColors.ButtonHighlight;
        }

        if (_service.InfoAssociado.Digitalizados.ResidenciaCarregado == true)
        {
            BTN_SelecionaResidencia.BackColor = Color.LightGreen;
        }
        else
        {
            BTN_SelecionaResidencia.BackColor = SystemColors.ButtonHighlight;
        }

        if (_service.InfoAssociado.Digitalizados.AutorizacaoCarregado == true)
        {
            BTN_SelecionaTermoAutorizacao.BackColor = Color.LightGreen;
        }
        else
        {
            BTN_SelecionaTermoAutorizacao.BackColor = SystemColors.ButtonHighlight;
        }

        if (_service.InfoAssociado.Digitalizados.ReqLicensaCarregado == true)
        {
            BTN_SelecionaReqLicensa.BackColor = Color.LightGreen;
        }
        else
        {
            BTN_SelecionaReqLicensa.BackColor = SystemColors.ButtonHighlight;
        }

        if (_service.InfoAssociado.Digitalizados.ReqINSSCarregado == true)
        {
            BTN_SelecionaReqINSS.BackColor = Color.LightGreen;
        }
        else
        {
            BTN_SelecionaReqINSS.BackColor = SystemColors.ButtonHighlight;
        }

        if (_service.InfoAssociado.Digitalizados.CanhotoProtocoloCarregado == true)
        {
            BTN_SelecionaCanhotoProtocolo.BackColor = Color.LightGreen;
        }
        else
        {
            BTN_SelecionaCanhotoProtocolo.BackColor = SystemColors.ButtonHighlight;
        }
    }
    private static void AbrirPasta(string caminho)
    {
        Process.Start("explorer.exe", caminho);
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
    private static string SalvarArquivo(string destino)
    {
        try
        {
            OpenFileDialog ofd = new()
            {
                Filter = "Arquivos PDF (*.pdf)|*.pdf"
            };
            if (DialogResult.OK == ofd.ShowDialog())
            {
                File.Copy(ofd.FileName, destino, true);
                MessageBox.Show
                (
                    $"Arquivo salvo com sucesso!",
                    "Sucesso!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return destino;
            }
            else
            {
                return string.Empty;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show
            (
                $"Ocorreu um erro ao salvar o arquivo: {ex.Message}",
                "Erro!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return string.Empty;
        }
    }
    private static string ExcluirArquivo(string destino)
    {
        try
        {
            if (MessageBox.Show("Deseja excluir o arquivo?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                File.Delete(destino);
                MessageBox.Show
                (
                    $"Arquivo excluído com sucesso!",
                    "Sucesso!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return string.Empty;
            }
            else
            {
                return destino;
            }
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
            return string.Empty;
        }
    }

    private void BTN_GeraDocumentacao_Click(object sender, EventArgs e)
    {
        ReqSeguroDefeso.SubstituirElementos(_service.InfoAssociado);
        Mensages.Alerta("Gerado com sucesso", "Informacao");
    }
}