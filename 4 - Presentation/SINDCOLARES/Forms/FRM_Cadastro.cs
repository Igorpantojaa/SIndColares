﻿using Servicos;
using Infraestrutura;
using Servicos.ComboBox;
using Servicos.Utilidades;
using SINDCOLARES.Formularios;
using SINDCOLARES.Forms;

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

    private void BTN_Salvar_Click(object sender, EventArgs e) => Salvar();
    private void TXB_CPF_Leave(object sender, EventArgs e) => FormataCPF();
    private void PB_Foto_Click(object sender, EventArgs e) => CarregaFoto();
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
            Mensagens.Alerta(ex.Message, "Erro");
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
        if (_service.AssociadoTemp.Digitalizados.Local != string.Empty)
        {
            OpenFileDialog ofd = new();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var destino = $"{_service.AssociadoTemp.Digitalizados.Local}\\FOTO.jpg";
                    if(!File.Exists(destino)) 
                    {
                        GestaoArquivos.SalvarArquivo(ofd.FileName, destino);
                        Mensagens.Alerta("Arquivo salvo com sucesso!", "Informacao");
                        _service.AssociadoTemp.Digitalizados.Foto = destino;
                        PB_Foto.ImageLocation = destino;
                    }
                    else
                    {
                        var opcao = Mensagens.Sobrecresver();
                        if(opcao)
                        {
                            GestaoArquivos.SalvarArquivo(ofd.FileName, destino);
                            Mensagens.Alerta("Arquivo substituido com sucesso!", "Informacao");
                            _service.AssociadoTemp.Digitalizados.Foto = destino;
                            PB_Foto.ImageLocation = destino;
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    Mensagens.Alerta($"{ex.Message}", "Erro");
                    _service.AssociadoTemp.Digitalizados.Foto = string.Empty;
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
        _service.AssociadoTemp.Nome = TXB_Nome.Text;
        _service.AssociadoTemp.Apelido = TXB_Apelido.Text;
        _service.AssociadoTemp.DataNascimento = DTP_DataNascimento.Value;
        _service.AssociadoTemp.Sexo = CB_Sexo.Text;
        _service.AssociadoTemp.Documentos.CPF = TXB_CPF.Text;
        _service.AssociadoTemp.EstadoCivil = CBO_EstadoCivil.Text;
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
        TXB_Nome.Text = _service.AssociadoTemp.Nome;
        TXB_Apelido.Text = _service.AssociadoTemp.Apelido;
        DTP_DataNascimento.Value = _service.AssociadoTemp.DataNascimento;
        CB_Sexo.Text = _service.AssociadoTemp.Sexo;
        CBO_EstadoCivil.Text = _service.AssociadoTemp.EstadoCivil;
        TXB_CPF.Text = _service.AssociadoTemp.Documentos.CPF;
        PB_Foto.ImageLocation = _service.AssociadoTemp.Digitalizados.Foto;
    }
    private void DocumentosAssociado()
    {
        ValidaDadosBasicos();
        if(_service.AssociadoTemp.Id == 0) 
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