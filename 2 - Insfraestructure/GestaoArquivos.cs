using System.Diagnostics;
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
    public static void AbrirPasta(string caminho)
    {
        Process.Start("explorer.exe", caminho);
    }
    public static string CriarDiretorioAssociado(string cpf)
    {
        try
        {
            var diretorio = $".\\Arquivos\\Associados\\[{cpf}]";
            if (!Directory.Exists(diretorio))
            {
                Directory.CreateDirectory(diretorio);
            }
            return diretorio;
        }
        catch
        {
            throw;
        }
    }
    public static void ExcluirDiretorioAssociado(string local)
    {
        try
        {
            if (Directory.Exists(local))
            {
                Directory.Delete(local, true);
            }
        }
        catch
        {
            throw;
        }
    }
    public static string SalvarFoto(string origem, string destino)
    {
        try
        {
            destino = $"{destino}\\FOTO.jpg";
            File.Copy(origem, destino, true);
            return destino;
        }
        catch
        {
            return string.Empty;
            throw;
        }
    }
    public static string SalvarArquivo(string origem, string destino)
    {
        try
        {
            destino = $"{destino}\\FOTO.jpg";
            File.Copy(origem, destino, true);
            return destino;
        }
        catch
        {
            return string.Empty;
            throw;
        }
    }
}