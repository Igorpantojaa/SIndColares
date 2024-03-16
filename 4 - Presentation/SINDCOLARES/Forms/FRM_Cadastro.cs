using Servicos;
using Infraestrutura;
using Servicos.ComboBox;
using Servicos.Utilidades;
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

    private void PB_Foto_Click(object sender, EventArgs e) => CarregaFoto();
    private void BTN_Salvar_Click(object sender, EventArgs e) => Salvar();
    private void TXB_CPF_Leave(object sender, EventArgs e) => FormataCPF();
    private void BTN_Cancelar_Click(object sender, EventArgs e) => Cancelar();
    private void FRM_Cadastro_Load(object sender, EventArgs e) => CarregaInformacoes();
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
        try
        {
            _service.Salvar();
            Mensagens.Alerta("Registro salvo com sucesso!", "Informacao");
            Close();
        }
        catch (Exception ex)
        {
            Mensagens.Alerta($"Não foi possível salvar o registtro!\n{ex.Message}", "Erro");
        }
    }
    private void Cancelar()
    {
        _service.Cancelar();
        Close();
    }
    private void CarregaFoto()
    {
        if(ValidaDadosBasicos()) _service.PastaAssociado();
        if (_service.InfoAssociado.Digitalizados.Local != string.Empty)
        {
            OpenFileDialog ofd = new();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var destino = _service.InfoAssociado.Digitalizados.Local;
                    var foto = GestaoArquivos.SalvarFoto(ofd.FileName, destino);
                    Mensagens.Alerta("Arquivo salvo com sucesso!", "Informacao");
                    _service.InfoAssociado.Digitalizados.Foto = foto;
                    PB_Foto.ImageLocation = foto;
                }
                catch (Exception ex)
                {
                    Mensagens.Alerta($"Houve um erro ao salvar o arquivo: {ex.Message}", "Erro");
                }
            }
        }
        else
        {
            Mensagens.Alerta("Preencha os campos Nome e CPF para criar a pasta do Associado.", "Informacao");
        }
    }
    private void FormataCPF()
    {
        if (CPF.ValidaCPF(TXB_CPF.Text) == true && TXB_CPF.Text.Length == 11)
        {
            var cpf = TXB_CPF.Text;
            TXB_CPF.Text = CPF.FormataCPF(cpf);
        }
    }
    private void AtualizaInfo()
    {
        _service.InfoAssociado.Nome = TXB_Nome.Text;
        _service.InfoAssociado.Apelido = TXB_Apelido.Text;
        _service.InfoAssociado.DataNascimento = DTP_DataNascimento.Value;
        _service.InfoAssociado.Sexo = CB_Sexo.Text;
        _service.InfoAssociado.Documentos.CPF = TXB_CPF.Text;
    }
    private bool ValidaDadosBasicos()
    {
        try
        {
            AtualizaInfo();
            if (TXB_CPF.Text != string.Empty && CPF.ValidaCPF(TXB_CPF.Text))
            {
                return true;
            }
            else
            {
                Mensagens.Alerta("CPF inválido!", "Erro");
                return false;
            }
        }
        catch (Exception ex)
        {
            Mensagens.Alerta($"{ex.Message}", "Erro!");
            return false;
        } 
    }
    private void CarregaInformacoes()
    {
        TXB_Nome.Text = _service.InfoAssociado.Nome;
        TXB_Apelido.Text = _service.InfoAssociado.Apelido;
        DTP_DataNascimento.Value = _service.InfoAssociado.DataNascimento;
        CB_Sexo.Text = _service.InfoAssociado.Sexo;
        TXB_CPF.Text = _service.InfoAssociado.Documentos.CPF;
        PB_Foto.ImageLocation = _service.InfoAssociado.Digitalizados.Foto;
    }
    private void DocumentosAssociado()
    {
        ValidaDadosBasicos();
        if(_service.InfoAssociado.Id == 0) 
        {
            AtualizaInfo();
            if (ValidaDadosBasicos() == true && _service.CPFnaBase() == false)
            {
                _service.PastaAssociado();
                new FRM_CarregaDocumentacao(_service).ShowDialog();
            }
            else
            {
                if (_service.CPFnaBase()) Mensagens.Alerta("CPF já cadastrado!", "Erro");
                else Mensagens.Alerta("Você precisa preencher o nome e o CPF para a criação da pasta do Associado.", "Erro");
            }
        }
        else
        {
            new FRM_CarregaDocumentacao(_service).ShowDialog();
        }
    }
}