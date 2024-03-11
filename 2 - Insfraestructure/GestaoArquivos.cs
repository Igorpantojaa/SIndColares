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
        var diretorio = $"{nome.ToUpper()} [{cpf}]";
        if (!Directory.Exists($".\\Associados\\{diretorio}"))
        {
            Directory.CreateDirectory($".\\Associados\\{diretorio}");
        }
        return diretorio;
    }
}
