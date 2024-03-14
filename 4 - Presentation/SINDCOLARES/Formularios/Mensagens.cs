namespace SINDCOLARES.Formularios
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
    }
}
