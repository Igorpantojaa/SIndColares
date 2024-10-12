using Servicos;
using SINDCOLARES.Forms;

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
            _service.LimparPeriodo();
            Close();
        }
        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            _service.LimparPeriodo();
            Close();
        }
        private void CHB_Periodo1_CheckedChanged(object sender, EventArgs e)
        {
            PeriodosAtivos();
        }

        private void AtualizaInfo()
        {
            _service.PeriodoTemp.DataPublicacao = DTP_DataPublicacao.Value;
            _service.PeriodoTemp.NumeroPublicacao = TXB_NumPublicacao.Text;
            if (CHB_Periodo1.Checked == true)
            {
                _service.PeriodoTemp.Periodo1Ativo = true;
                _service.PeriodoTemp.InicioPeriodo1 = DTP_Periodo1Inicio.Value;
                _service.PeriodoTemp.FimPeriodo1 = DTP_Periodo1Fim.Value;
            }
            else
            {
                _service.PeriodoTemp.Periodo1Ativo = false;
            };
            if (CHB_Periodo2.Checked == true)
            {
                _service.PeriodoTemp.Periodo2Ativo = true;               
                _service.PeriodoTemp.InicioPeriodo2 = DTP_Periodo2Inicio.Value;
                _service.PeriodoTemp.FimPeriodo2 = DTP_Periodo2Fim.Value;
            }
            else
            {
                _service.PeriodoTemp.Periodo2Ativo = false;
            };
        }
        private void SalvaPeriodo()
        {
            try
            {
                AtualizaInfo();
                _service.PeriodoService.Salvar(_service.PeriodoTemp);

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
            TXB_NumPublicacao.Text = _service.PeriodoTemp.NumeroPublicacao;
            CHB_Periodo1.Checked = _service.PeriodoTemp.Periodo1Ativo;
            CHB_Periodo2.Checked = _service.PeriodoTemp.Periodo2Ativo;
            LBL_Vigencia.Text = _service.PeriodoTemp.DataPublicacao.Year.ToString();
            DTP_DataPublicacao.Value = _service.PeriodoTemp.DataPublicacao;
            DTP_Periodo1Inicio.Value = _service.PeriodoTemp.InicioPeriodo1;
            DTP_Periodo1Fim.Value = _service.PeriodoTemp.FimPeriodo1;
            DTP_Periodo2Inicio.Value = _service.PeriodoTemp.InicioPeriodo2;
            DTP_Periodo2Fim.Value = _service.PeriodoTemp.FimPeriodo2;
        }
    }
}
