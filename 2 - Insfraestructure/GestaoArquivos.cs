using System.Diagnostics;

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

    public static void SalvarArquivo(string origem, string destino)
    {
        try
        {
            File.Copy(origem, destino, true);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public static void ExcluirArquivo(string destino)
    {
        try
        {
            File.Delete(destino);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}