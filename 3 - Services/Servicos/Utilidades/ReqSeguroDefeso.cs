using Modelos;
using Xceed.Words.NET;

namespace Servicos.Utilidades;

public class ReqSeguroDefeso
{
    public static void SubstituirElementos(Associado a)
    {
        try
        {
            var doc = DocX.Load(".\\Templates\\RequerimentoSeguroDefeso.docx");

            doc.ReplaceText("<NomeAssociado>", $"{a.Nome.ToUpper()}");
            doc.ReplaceText("<NomeMae>", $"{a.Documentos.RG.NomeMae.ToUpper()}");
            doc.ReplaceText("<DataNascimento>", $"{a.DataNascimento.ToShortDateString()}");
            doc.ReplaceText("<CPF>", $"{a.Documentos.CPF}");
            doc.ReplaceText("<RG>", $"{a.Documentos.RG.Numero}");
            doc.ReplaceText("<PIS>", $"{a.Documentos.PIS}");
            doc.ReplaceText("<Rua>", $"{a.Endereco.Rua}");
            doc.ReplaceText("<Numero>", $"{a.Endereco.Numero}");
            doc.ReplaceText("<Complemento>", $"{a.Endereco.Localidade}");
            doc.ReplaceText("<Telefone>", $"{a.Contato.Telefone}");
            doc.ReplaceText("<NumeroPublicacao>", $"{a.Documentos.CEI}");
            doc.ReplaceText("<DataPublicacao>", $"{a.Documentos.CEI}");
            doc.ReplaceText("<P1Inicio>", $"{a.Documentos.CEI}");
            doc.ReplaceText("<P1Fim>", $"{a.Documentos.CEI}");
            doc.ReplaceText("<P2Inicio>", $"{a.Documentos.CEI}");
            doc.ReplaceText("<P2Fim>", $"{a.Documentos.CEI}");
            doc.ReplaceText("<RGP>", $"{a.Profissao.RGP}");
            doc.ReplaceText("<UF>", $"{a.Endereco.UF}");
            doc.ReplaceText("<AB>", $"{a.Profissao.AB}");
            doc.ReplaceText("<NTrip>", $"{a.Profissao}");
            doc.ReplaceText("<CPFProp>", $"{a.Documentos.CEI}");
            doc.SaveAs("teste01.docx");
        }
        catch(Exception ex) 
        {
            throw new Exception($"Houve um problema ao gerar o arquivo:\n{ex.Message}");
        }
    }
}