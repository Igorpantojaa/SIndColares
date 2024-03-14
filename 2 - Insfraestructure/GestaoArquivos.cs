using System.Security.Cryptography;

namespace Infraestrutura;

public class GestaoArquivos
{
    public static void CriarDiretorioDeArquivos()
    {
        if (!Directory.Exists(".\\Arquivos\\Associados"))
        {
            Directory.CreateDirectory(".\\Arquivos\\Associados");
        }
    }

    public static string DiretorioAssociado(string cpf, string nome)
    {
        var diretorio = $".\\Arquivos\\Associados\\{nome.ToUpper()} [{cpf}]";
        if (!Directory.Exists(diretorio))
        {
            Directory.CreateDirectory(diretorio);
        }
        return diretorio;
    }

    public static string SalvarFoto(string origem, string destino)
    {
        try
        {
            if (!Directory.Exists(destino))
            {
                destino = $"{destino}//FOTO.jpg";
                File.Copy(origem, destino, true);
                return destino;
            }
            else
            {
                return string.Empty;
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}