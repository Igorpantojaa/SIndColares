using Servicos;
using SINDCOLARES.Formularios;

namespace SINDCOLARES;

public partial class FRM_Cadastro : Form
{
    private readonly ICadastroService _cadastroService;

    public FRM_Cadastro(ICadastroService cs)
    {
        _cadastroService = cs;
        InitializeComponent();
    }

    private void PB_Foto_Click(object sender, EventArgs e) => SalvaFoto();
    private void BTN_Salvar_Click(object sender, EventArgs e) => Salvar();
    private void BTN_Cancelar_Click(object sender, EventArgs e) => Cancelar();
    private void BTN_Digitalizados_Click(object sender, EventArgs e) => DocumentosAssociado();
    private void BTN_Contato_Click(object sender, EventArgs e) => new FRM_Contato(_cadastroService).ShowDialog();
    private void BTN_Endereco_Click(object sender, EventArgs e) => new FRM_Endereco(_cadastroService).ShowDialog();
    private void BTN_filiacao_Click(object sender, EventArgs e) => new FRM_Filiacao(_cadastroService).ShowDialog();
    private void BTN_Profissao_Click(object sender, EventArgs e) => new FRM_Profissao(_cadastroService).ShowDialog();
    private void BTN_Documentos_Click(object sender, EventArgs e) => new FRM_Documentos(_cadastroService).ShowDialog();
    private void BTN_Escolaridade_Click(object sender, EventArgs e) => new FRM_Escolaridade(_cadastroService).ShowDialog();

    private void DocumentosAssociado()
    {
        AtualizaInfo();
        if (_cadastroService.InfoAssociado.Documentos.CPF != string.Empty &&
            _cadastroService.InfoAssociado.Nome != string.Empty)
        {
            new FRM_CarregaDocumentacao(_cadastroService).ShowDialog();
        }
        else
        {
            var msg = "Você precisa preencher o nome e o CPF para a criação da pasta do Associado.";
            MessageBox.Show(msg, "Atenção", MessageBoxButtons.OK ,MessageBoxIcon.Warning);
        }
        return;
    }

    private void Salvar()
    {
        AtualizaInfo();
    }

    private void Cancelar()
    {
        Close();
    }
    private void SalvaFoto()
    {
        var destino = $"{_cadastroService.InfoAssociado.Digitalizados.Local}\\FOTO.jpg";
        OpenFileDialog ofd = new();
        if(ofd.ShowDialog() == DialogResult.OK)
        {
            try
            {
                File.Copy(ofd.FileName, destino, true);
                MessageBox.Show("Arquivo salvo com sucesso!", "Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um erro ao salvar o arquivo: {ex.Message}", "Erro");
            }
        }
    }
    private void AtualizaInfo()
    {
        _cadastroService.InfoAssociado.Nome = TXB_Nome.Text;
        _cadastroService.InfoAssociado.Apelido = TXB_Apelido.Text;
        _cadastroService.InfoAssociado.DataNascimento = DTP_DataNascimento.Value;
        _cadastroService.InfoAssociado.Sexo = CB_Sexo.SelectedText;
        _cadastroService.InfoAssociado.Documentos.CPF = TXB_CPF.Text;

    }
}