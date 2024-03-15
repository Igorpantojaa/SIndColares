using Servicos;

namespace SINDCOLARES.Formularios
{
    public partial class FRM_CadastraPeriodo : Form
    {
        private readonly ICadastroService _service;
        public FRM_CadastraPeriodo(ICadastroService service)
        {
            _service = service;
            InitializeComponent();
            RecuperaPeriodo();
            PeriodosAtivos();
        }



        private void BTN_Salvar_Click(object sender, EventArgs e)
        {
            SalvaPeriodo();
            _service.LimpaPeriodo();
            Close();
        }
        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            _service.LimpaPeriodo();
            Close();
        }
        private void CHB_Periodo1_CheckedChanged(object sender, EventArgs e)
        {
            PeriodosAtivos();
        }

        private void AtualizaInfo()
        {
            if (CHB_Periodo1.Checked == true)
            {
                _service.Periodo.Periodo1Ativo = true;
                _service.Periodo.DataPublicacao = DTP_DataPublicacao.Value;
                _service.Periodo.InicioPeriodo1 = DTP_Periodo1Inicio.Value;
                _service.Periodo.FimPeriodo1 = DTP_Periodo1Fim.Value;
            }
            else
            {
                _service.Periodo.Periodo1Ativo = false;
            }
            if (CHB_Periodo2.Checked == true)
            {
                _service.Periodo.Periodo2Ativo = true;
                _service.Periodo.DataPublicacao = DTP_DataPublicacao.Value;
                _service.Periodo.InicioPeriodo1 = DTP_Periodo1Inicio.Value;
                _service.Periodo.FimPeriodo1 = DTP_Periodo1Fim.Value;
            }
            else
            {
                _service.Periodo.Periodo2Ativo = false;
            }
        }
        private void SalvaPeriodo()
        {
            try
            {
                AtualizaInfo();
                _service.SalvarPeriodo();

            }
            catch (Exception ex)
            {
                Mensagens.Alerta("Erro ao salvar o registro:\n" +
                                $"{ex.Message}", "Erro");
            }
        }
        private void PeriodosAtivos()
        {
            if (CHB_Periodo1.Checked == true)
            {
                DTP_Periodo1Inicio.Enabled = true;
                DTP_Periodo1Fim.Enabled = true;
            }
            else
            {
                DTP_Periodo1Inicio.Enabled = false;
                DTP_Periodo1Fim.Enabled = false;
            }

            if (CHB_Periodo2.Checked == true)
            {
                DTP_Periodo2Inicio.Enabled = true;
                DTP_Periodo2Fim.Enabled = true;
            }
            else
            {
                DTP_Periodo2Inicio.Enabled = false;
                DTP_Periodo2Fim.Enabled = false;
            }
        }
        private void RecuperaPeriodo()
        {
            CHB_Periodo1.Checked = _service.Periodo.Periodo1Ativo;
            CHB_Periodo2.Checked = _service.Periodo.Periodo2Ativo;
            LBL_Vigencia.Text = _service.Periodo.DataPublicacao.Year.ToString();
            DTP_DataPublicacao.Value = _service.Periodo.DataPublicacao;
            DTP_Periodo1Inicio.Value = _service.Periodo.InicioPeriodo1;
            DTP_Periodo1Fim.Value = _service.Periodo.FimPeriodo1;
            DTP_Periodo2Inicio.Value = _service.Periodo.InicioPeriodo2;
            DTP_Periodo2Fim.Value = _service.Periodo.FimPeriodo2;
        }
    }
}
