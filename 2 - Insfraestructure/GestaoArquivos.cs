namespace Infraestrutura;

public class GestaoArquivos
{
    public static void CriarDiretorioDeArquivos()
    {
        if (!Directory.Exists(".\\Associados"))
        {
            Directory.CreateDirectory(".\\Associados");
        }
    }

    public static string DiretorioAssociado(string cpf, string nome)
    {
        var diretorio = $".\\Associados\\{nome.ToUpper()} [{cpf}]";
        if (!Directory.Exists(diretorio))
        {
            Directory.CreateDirectory(diretorio);
        }
        return diretorio;
    }
}