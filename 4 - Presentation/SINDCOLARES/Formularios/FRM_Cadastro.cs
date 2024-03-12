using Servicos;
using Servicos.ComboBox;
using SINDCOLARES.Formularios;

namespace SINDCOLARES;

public partial class FRM_Cadastro : Form
{
    private readonly ICadastroService _service;

    public FRM_Cadastro(ICadastroService cs)
    {
        _service = cs;
        InitializeComponent();
        CB_Sexo.DataSource = ConteudoComboBox.Sexo();
    }

    private void PB_Foto_Click(object sender, EventArgs e) => SalvaFoto();
    private void BTN_Salvar_Click(object sender, EventArgs e) => Salvar();
    private void BTN_Cancelar_Click(object sender, EventArgs e) => Cancelar();
    private void BTN_Digitalizados_Click(object sender, EventArgs e) => DocumentosAssociado();
    private void BTN_Contato_Click(object sender, EventArgs e) => new FRM_Contato(_service).ShowDialog();
    private void BTN_Endereco_Click(object sender, EventArgs e) => new FRM_Endereco(_service).ShowDialog();
    private void BTN_filiacao_Click(object sender, EventArgs e) => new FRM_Filiacao(_service).ShowDialog();
    private void BTN_Profissao_Click(object sender, EventArgs e) => new FRM_Profissao(_service).ShowDialog();
    private void BTN_Documentos_Click(object sender, EventArgs e) => new FRM_Documentos(_service).ShowDialog();
    private void BTN_Escolaridade_Click(object sender, EventArgs e) => new FRM_Escolaridade(_service).ShowDialog();

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
        if (ValidaDadosBasicos() == true)
        {
            var destino = $"{_service.InfoAssociado.Digitalizados.Local}\\FOTO.jpg";
            OpenFileDialog ofd = new();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.Copy(ofd.FileName, destino, true);
                    MessageBox.Show
                    (
                        "Arquivo salvo com sucesso!",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    PB_Foto.ImageLocation = destino;
                }
                catch (Exception ex)
                {
                    MessageBox.Show
                    (
                        $"Houve um erro ao salvar o arquivo: {ex.Message}",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }
        else
        {
            MessageBox.Show("Preencha os campos Nome e CPF para criar a pasta do Associado.");
        }
    }
    private void AtualizaInfo()
    {
        _service.InfoAssociado.Nome = TXB_Nome.Text;
        _service.InfoAssociado.Apelido = TXB_Apelido.Text;
        _service.InfoAssociado.DataNascimento = DTP_DataNascimento.Value;
        _service.InfoAssociado.Sexo = CB_Sexo.SelectedText;
        _service.InfoAssociado.Documentos.CPF = TXB_CPF.Text;
    }
    private bool ValidaDadosBasicos()
    {
        AtualizaInfo();
        if (_service.InfoAssociado.Documentos.CPF != string.Empty &&
           _service.InfoAssociado.Nome != string.Empty)
        {
            _service.PastaAssociado();
            return true;
        }
        else
        {
            return false;
        }
    }
    private void DocumentosAssociado()
    {
        AtualizaInfo();
        if (ValidaDadosBasicos() == true)
        {
            new FRM_CarregaDocumentacao(_service).ShowDialog();
        }
        else
        {
            var msg = "Você precisa preencher o nome e o CPF para a criação da pasta do Associado.";
            MessageBox.Show(msg, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        return;
    }
    private void FRM_Cadastro_Load(object sender, EventArgs e)
    {
        TXB_Nome.Text = _service.InfoAssociado.Nome;
        TXB_Apelido.Text = _service.InfoAssociado.Apelido;
        DTP_DataNascimento.Value = _service.InfoAssociado.DataNascimento;
        CB_Sexo.SelectedText = _service.InfoAssociado.Sexo;
        TXB_CPF.Text = _service.InfoAssociado.Documentos.CPF;
        PB_Foto.ImageLocation = _service.InfoAssociado.Digitalizados.Foto;
    }
}