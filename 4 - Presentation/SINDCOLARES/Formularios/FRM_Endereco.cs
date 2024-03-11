using Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SINDCOLARES.Formularios
{
    public partial class FRM_Endereco : Form
    {
        private readonly ICadastroService _service;
        public FRM_Endereco(ICadastroService service)
        {
            _service = service;
            InitializeComponent();
        }

        private void BTN_Salvar_Click(object sender, EventArgs e)
        {
            _service.InfoAssociado.Endereco.CEP = TXB_CEP.Text;
            _service.InfoAssociado.Endereco.UF = CB_UF.SelectedText;
            _service.InfoAssociado.Endereco.Municipio = TXB_Municipio.Text;
            _service.InfoAssociado.Endereco.Localidade = TXB_Localidade.Text;
            _service.InfoAssociado.Endereco.Bairro = TXB_Bairro.Text;
            _service.InfoAssociado.Endereco.Rua = TXB_Rua.Text;
            _service.InfoAssociado.Endereco.Numero = TXB_Numero.Text;
            MessageBox.Show("Dados atualizados.", "Sucersso!");
            Close();
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
