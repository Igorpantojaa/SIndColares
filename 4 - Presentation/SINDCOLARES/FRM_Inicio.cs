using Infraestrutura;
using Infraestrutura.DTOs;
using Servicos;

namespace SINDCOLARES;

public partial class FRM_Inicio : Form
{
    private readonly ICadastroService _servico;
    public FRM_Inicio(IAssociadoDTO context)
    {
        _servico = new CadastroService(context);
        InitializeComponent();
        GestaoArquivos.CriarDiretorioDeArquivos();
    }

    private void BTN_NovoCadastro_Click(object sender, EventArgs e)
    {
        FRM_Cadastro cad = new(_servico);
        cad.ShowDialog();
    }
}