using Servicos;

namespace SINDCOLARES.Formularios;

public partial class FRM_CarregaDocumentacao : Form
{
    private readonly ICadastroService _service;
    private readonly string _local;

    public FRM_CarregaDocumentacao(ICadastroService service)
    {
        _service = service;
        _service.CriarPasta();
        _local = _service.InfoAssociado.Digitalizados.Local;
        InitializeComponent();
    }

    private void BTN_Voltar_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void BTN_SelecionaCPF_Click(object sender, EventArgs e)
    {
        var destino = $"{_local}\\CPF.pdf";
        _service.InfoAssociado.Digitalizados.CPF = SalvarArquivo(destino);
    }

    private void BTN_SelecionaRG_Click(object sender, EventArgs e)
    {
        var destino = $"{_local}\\RG.pdf";
        _service.InfoAssociado.Digitalizados.RG = SalvarArquivo(destino);
    }

    private void BTN_SelecionaFiliacao_Click(object sender, EventArgs e)
    {
        var destino = $"{_local}\\DECLARACAO_DE_FILIACAO.pdf";
        _service.InfoAssociado.Digitalizados.Filiacao = SalvarArquivo(destino);
    }

    private void BTN_SelecionaResidencia_Click(object sender, EventArgs e)
    {
        var destino = $"{_local}\\COMPROVANTE_DE_RESIDENCIA.pdf";
        _service.InfoAssociado.Digitalizados.Residencia = SalvarArquivo(destino);
    }

    private void BTN_SelecionaTermoAutorizacao_Click(object sender, EventArgs e)
    {
        var destino = $"{_local}\\TERMO_DE_AUTORIZACAO.pdf";
        _service.InfoAssociado.Digitalizados.Autorizacao = SalvarArquivo(destino);
    }

    private void BTN_SelecionaReqLicensa_Click(object sender, EventArgs e)
    {
        var destino = $"{_local}\\REQUERIMENTO_DE_LICENSA.pdf";
        _service.InfoAssociado.Digitalizados.ReqLicensa =  SalvarArquivo(destino);
    }

    private void BTN_SelecionaReqINSS_Click(object sender, EventArgs e)
    {
        var destino = $"{_local}\\REQUERIMENTO_INSS.pdf";
        _service.InfoAssociado.Digitalizados.ReqINSS = SalvarArquivo(destino);
    }

    private void BTN_SelecionaCanhotoProtocolo_Click(object sender, EventArgs e)
    {
        var destino = $"{_local}\\CANHOTO_PROTOCOLO.pdf";
        _service.InfoAssociado.Digitalizados.CanhotoProtocolo = SalvarArquivo(destino);
    }

    private static string SalvarArquivo(string destino)
    {
        OpenFileDialog ofd = new();
        ofd.ShowDialog();
        File.Copy(ofd.FileName, destino, true);
        return destino;
    }
}