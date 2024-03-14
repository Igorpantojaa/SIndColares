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
        }

        private void BTN_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                _service.LimpaPeriodo();
                AtualizaInfo();
                _service.SalvarPeriodo();

            }
            catch (Exception ex)
            {
                Mensagens.Alerta("Erro ao salvar o registro:\n" +
                                $"{ex.Message}", "Erro");
            }
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            _service.LimpaPeriodo();
            Close();
        }
        private void AtualizaInfo()
        {
            if(CHB_Periodo1.Checked == true) 
            {
                _service.Periodo.Periodo1Ativo = true;
                _service.Periodo.AnoVigencia = DTP_PeriodoVigencia.Value.Year.ToString();
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
                _service.Periodo.AnoVigencia = DTP_PeriodoVigencia.Value.Year.ToString();
                _service.Periodo.InicioPeriodo1 = DTP_Periodo1Inicio.Value;
                _service.Periodo.FimPeriodo1 = DTP_Periodo1Fim.Value;
            }
            else
            {
                _service.Periodo.Periodo2Ativo = false;
            }
        }
    }
}
