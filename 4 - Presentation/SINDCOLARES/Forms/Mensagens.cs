using System.Windows.Forms;

namespace SINDCOLARES.Forms
{
    public class Mensagens
    {
        public static void Alerta(string mensagem, string tipo)
        {
            switch (tipo)
            {
                case "Erro":
                    {
                        MessageBox.Show
                        (
                            mensagem,
                            "Erro!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                    break;
                case "Alerta":
                    {

                        MessageBox.Show
                        (
                            mensagem,
                            "Atenção",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }
                    break;
                case "Informacao":
                    {

                        MessageBox.Show
                        (
                            mensagem,
                            "Informação",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    break;
            }
        }
        public static bool Sobrecresver()
        {
            if (DialogResult.Yes == MessageBox.Show(
                "Já existe um arquivo no local, deseja sobrescrever?",
                "Atenção",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                ))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Exclusao()
        {
            if (DialogResult.Yes == MessageBox.Show(
                "Deseja excluir o arquivo?",
                "Atenção",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                ))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
