using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SINDCOLARES
{
    public partial class FRM_Inicio : Form
    {
        public FRM_Inicio()
        {
            InitializeComponent();
        }

        private void BTN_NovoCadastro_Click(object sender, EventArgs e)
        {
            FRM_Cadastro cad = new();
            cad.ShowDialog();
        }
    }
}
