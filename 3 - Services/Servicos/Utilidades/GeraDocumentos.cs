using Modelos;
using Spire.Doc;
using Xceed.Words.NET;

namespace Servicos.Utilidades;

public class GeraDocumentos
{
    private readonly string _destino;
    private readonly Periodo _periodo;
    private readonly Associado _associado;

    public GeraDocumentos(Associado associado, Periodo periodo, string destino)
    {
        _periodo = periodo;
        _associado = associado;
        _destino = CriarPasta($"{destino}");
    }

    public string Procuracao(bool PDF, bool pastaIndividual)
    {
        try
        {
            var doc = DocX.Load(".\\Arquivos\\Templates\\Procuracao.docx");
            doc.ReplaceText("<Nome>", $"{_associado.Nome.ToUpper()}");
            doc.ReplaceText("<CPF>", $"{_associado.Documentos.CPF.ToUpper()}");
            doc.ReplaceText("<RG>", $"{_associado.Documentos.RG.Numero}/{_associado.Documentos.RG.OrgaoEmissor}/{_associado.Documentos.RG.EstadoEmissao}");
            doc.ReplaceText("<Endereco>", $"{_associado.Endereco.Rua.ToUpper()}, {_associado.Endereco.Numero}");
            doc.ReplaceText("<Bairro>", $"{_associado.Endereco.Bairro}");
            doc.ReplaceText("<DataAtual>", $"{(_periodo.InicioPeriodo1.AddDays(13)).ToLongDateString()}");
            if (PDF)
            {
                var doctemp = $"{LocalSalvamento(pastaIndividual)}\\ProcuracaoTemp.docx";
                doc.SaveAs(doctemp);
                var destino = $"{LocalSalvamento(pastaIndividual)}\\Procuracao [{_associado.Nome.ToUpper()}].pdf";
                SaidaEmPDF(doctemp, destino);
                File.Delete(doctemp);
                return destino;
            }
            else
            {
                var destino = $"{LocalSalvamento(pastaIndividual)}\\Procuracao [{_associado.Nome.ToUpper()}].docx";
                doc.SaveAs(destino);
                return destino;
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public string ReqSeguroDefeso(bool PDF, bool pastaIndividual)
    {
        try
        {
            var doc = DocX.Load(".\\Arquivos\\Templates\\RequerimentoSeguroDefeso.docx");
            doc.ReplaceText("<NomeAssociado>", $"{_associado.Nome.ToUpper()}");
            doc.ReplaceText("<NomeMae>", $"{_associado.Documentos.RG.NomeMae.ToUpper()}");
            doc.ReplaceText("<DataNascimento>", $"{_associado.DataNascimento.ToShortDateString()}");
            doc.ReplaceText("<CPF>", $"{_associado.Documentos.CPF}");
            doc.ReplaceText("<RG>", $"{_associado.Documentos.RG.Numero}");
            doc.ReplaceText("<PIS>", $"{_associado.Documentos.PIS}");
            doc.ReplaceText("<CEI>", $"{_associado.Documentos.CEI}");
            doc.ReplaceText("<Rua>", $"{_associado.Endereco.Rua}");
            doc.ReplaceText("<Numero>", $"{_associado.Endereco.Numero}");
            doc.ReplaceText("<Complemento>", $"{_associado.Endereco.Bairro}");
            doc.ReplaceText("<Telefone>", $"{_associado.Contato.Telefone}");
            doc.ReplaceText("<NPub>", $"{_periodo.NumeroPublicacao}");
            doc.ReplaceText("<DataPub>", $"{_periodo.GetDataPublicacao}");
            doc.ReplaceText("<P1Inicio>", $"{_periodo.GetInicioVigencia1}");
            doc.ReplaceText("<P1Fim>", $"{_periodo.GetFimVigencia1}");
            doc.ReplaceText("<P2Inicio>", $"{_periodo.GetInicioVigencia2}");
            doc.ReplaceText("<P2Fim>", $"{_periodo.GetFimVigencia2}");
            doc.ReplaceText("<RGP>", $"{_associado.Profissao.RGP}");
            doc.ReplaceText("<Nome>", $"{_associado.Profissao.NumeroTripulantes}");
            doc.ReplaceText("<UFP>", $"{_associado.Profissao.UFPesca}");
            doc.ReplaceText("<AB>", $"{_associado.Profissao.AB}");
            doc.ReplaceText("<NTrip>", $"{_associado.Profissao.GetTripulantes}");
            doc.ReplaceText("<CPFProp>", $"{_associado.Profissao.CPFProprietario}");
            if (PDF)
            {
                var doctemp = $"{LocalSalvamento(pastaIndividual)}\\DocTemp.docx";
                doc.SaveAs(doctemp);
                var destino = $"{LocalSalvamento(pastaIndividual)}\\Requerimento_de_Seguro_Defeso [{_associado.Nome.ToUpper()}].pdf";
                SaidaEmPDF(doctemp, destino);
                File.Delete(doctemp);
                return destino;
            }
            else
            {
                var destino = $"{LocalSalvamento(pastaIndividual)}\\Requerimento_de_Seguro_Defeso [{_associado.Nome.ToUpper()}].docx";
                doc.SaveAs(destino);
                return destino;
            }
        }
        catch
        {
            throw;
        }
    }
    public string RegistroInicial(bool PDF, bool pastaIndividual, DateTime data)
    {
        try
        {
            var doc = DocX.Load(".\\Arquivos\\Templates\\RegistroInicial.docx");
            doc.ReplaceText("<A01>", $"{_associado.Nome.ToUpper()}");
            doc.ReplaceText("<A02>", $"{CPF.SemFormatacao(_associado.Documentos.CPF)}");
            doc.ReplaceText("<A04>", $"{_associado.Documentos.RG.Numero}");
            doc.ReplaceText("<A05>", $"{_associado.Documentos.RG.OrgaoEmissor}/{_associado.Documentos.RG.EstadoEmissao}");
            doc.ReplaceText("<A06>", $"{_associado.Documentos.RG.DataEmisao.ToShortDateString()}");
            doc.ReplaceText("<A07>", $"{_associado.DataNascimento.ToShortDateString()}");
            doc.ReplaceText("<A08A>", $"{Sexo(_associado.Sexo, "<A08A>")}");
            doc.ReplaceText("<A08B>", $"{Sexo(_associado.Sexo, "<A08B>")}");
            doc.ReplaceText("<A09>", $"{_associado.Documentos.RG.NomePai.ToUpper()}");
            doc.ReplaceText("<A10>", $"{_associado.Documentos.RG.NomeMae.ToUpper()}");
            doc.ReplaceText("<A11>", $"{_associado.Apelido.ToUpper()}");
            doc.ReplaceText("<A12>", $"{_associado.Documentos.PIS}");
            doc.ReplaceText("<B13>", $"{_associado.Endereco.Rua}, {_associado.Endereco.Numero}");
            doc.ReplaceText("<B14>", $"{_associado.Endereco.CEP}");
            doc.ReplaceText("<B15/B16>", $"{_associado.Endereco.Municipio}/{_associado.Endereco.UF}");
            doc.ReplaceText("<B17>", $"{_associado.Endereco.Localidade}");
            doc.ReplaceText("<B18>", $"{_associado.Contato.Telefone}");
            doc.ReplaceText("<B19>", $"{_associado.Contato.Email}");
            doc.ReplaceText("<C20A>", $"{CategoriaPesca(_associado.Profissao.Categoria, "<C20A>")}");
            doc.ReplaceText("<C20B>", $"{CategoriaPesca(_associado.Profissao.Categoria, "<C20B>")}");
            doc.ReplaceText("<D21A>", $"{FormaPesca(_associado.Profissao.FormaPesca, "<D21A>")}");
            doc.ReplaceText("<D21B>", $"{FormaPesca(_associado.Profissao.FormaPesca, "<D21B>")}");
            doc.ReplaceText("<D22>", $"{_associado.Profissao.NomeEmbarcacao}");
            doc.ReplaceText("<D23>", $"{_associado.Profissao.RGP}");
            doc.ReplaceText("<D24>", $"{_associado.Profissao.AB}");
            doc.ReplaceText("<D25A>", $"{Escolha(_associado.Profissao.ProdutoPesca.Peixes, "<D25A>")}");
            doc.ReplaceText("<D25B>", $"{Escolha(_associado.Profissao.ProdutoPesca.Crustaceos, "<D25B>")}");
            doc.ReplaceText("<D25C>", $"{Escolha(_associado.Profissao.ProdutoPesca.Mariscos, "<D25C>")}");
            doc.ReplaceText("<D25D>", $"{Escolha(_associado.Profissao.ProdutoPesca.Algas, "<D25D>")}");
            doc.ReplaceText("<D25E>", $"{Escolha(_associado.Profissao.ProdutoPesca.Outros, "<D25E>")}");
            doc.ReplaceText("<D26A>", "  ");
            doc.ReplaceText("<D26B>", "  ");
            doc.ReplaceText("<D26C>", "X");
            doc.ReplaceText("<D26D>", "  ");
            doc.ReplaceText("<D26E>", "  ");
            doc.ReplaceText("<D26F>", "  ");
            doc.ReplaceText("<D27>", $"{_associado.Profissao.LocalPesca}");
            doc.ReplaceText("<E28A>", $"{Escolha(_associado.Profissao.Empregado, "<E28A>")}");
            doc.ReplaceText("<E28B>", $"{Escolha(_associado.Profissao.Empregado, "<E28B>")}");
            doc.ReplaceText("<E29A>", $"{Escolha(_associado.Profissao.Empregado, "<E29A>")}");
            doc.ReplaceText("<E29B>", $"{Escolha(_associado.Profissao.Empregado, "<E29B>")}");
            doc.ReplaceText("<F30A>", $"{Escolaridade(_associado.Escolaridade.Formacao, "<F30A>")}");
            doc.ReplaceText("<F30B>", $"{Escolaridade(_associado.Escolaridade.Formacao, "<F30B>")}");
            doc.ReplaceText("<F30C>", $"{Escolaridade(_associado.Escolaridade.Formacao, "<F30C>")}");
            doc.ReplaceText("<F30D>", $"{Escolaridade(_associado.Escolaridade.Formacao, "<F30D>")}");
            doc.ReplaceText("<F30E>", $"{Escolaridade(_associado.Escolaridade.Formacao, "<F30E>")}");
            doc.ReplaceText("<F30F>", $"{Escolaridade(_associado.Escolaridade.Formacao, "<F30F>")}");
            doc.ReplaceText("<F30G>", $"{Escolaridade(_associado.Escolaridade.Formacao, "<F30G>")}");
            doc.ReplaceText("<F30H>", $"{Escolaridade(_associado.Escolaridade.Formacao, "<F30H>")}");
            doc.ReplaceText("<F30I>", $"{Escolaridade(_associado.Escolaridade.Formacao, "<F30I>")}");
            doc.ReplaceText("<F30J>", $"{Escolaridade(_associado.Escolaridade.Formacao, "<F30J>")}");
            doc.ReplaceText("<F31A>", $"{DecEscolaridade(_associado.Escolaridade.Autodeclaracao, "<F31A>")}");
            doc.ReplaceText("<F31B>", $"{DecEscolaridade(_associado.Escolaridade.Autodeclaracao, "<F31B>")}");
            doc.ReplaceText("<F31C>", $"{DecEscolaridade(_associado.Escolaridade.Autodeclaracao, "<F31C>")}");
            doc.ReplaceText("<G32A>", $"{Escolha(_associado.Filiacao.Filiado, "<G32A>")}");
            doc.ReplaceText("<G32B>", $"{Escolha(_associado.Filiacao.Filiado, "<G32B>")}");
            doc.ReplaceText("<G33A>", "  ");
            doc.ReplaceText("<G33B>", "X");
            doc.ReplaceText("<G33C>", "  ");
            doc.ReplaceText("<G33D>", "  ");
            doc.ReplaceText("<DataCompleta>", $"{data.ToLongDateString()}");
            if (PDF)
            {
                var doctemp = $"{LocalSalvamento(pastaIndividual)}\\DocTemp.docx";
                doc.SaveAs(doctemp);
                var destino = $"{LocalSalvamento(pastaIndividual)}\\Registro_Inicial_EFAP [{_associado.Nome.ToUpper()}].pdf";
                SaidaEmPDF(doctemp, destino);
                File.Delete(doctemp);
                return destino;
            }
            else
            {
                var destino = $"{LocalSalvamento(pastaIndividual)}\\Registro_Inicial_EFAP [{_associado.Nome.ToUpper()}].docx";
                doc.SaveAs(destino);
                return destino;
            }
        }
        catch (Exception ex)
        {
            throw new(ex.Message);
        }
    }
    public string DeclaracaoFiliacao(bool PDF, bool pastaIndividual, DateTime data)
    {
        try
        {
            var doc = DocX.Load(".\\Arquivos\\Templates\\DeclaracaoFiliacao.docx");
            doc.ReplaceText("<Nome>", $"{_associado.Nome.ToUpper()}");
            doc.ReplaceText("<NumeroCPF>", $"{_associado.Documentos.CPF}");
            doc.ReplaceText("<NumeroRG>", $"{_associado.Documentos.RG.Numero} {_associado.Documentos.RG.OrgaoEmissor}/{_associado.Documentos.RG.EstadoEmissao}");
            doc.ReplaceText("<EnderecoCompleto>", $"{_associado.Endereco.Rua}, {_associado.Endereco.Numero} - {_associado.Endereco.Localidade}.");
            doc.ReplaceText("<CidadeUF>", $"{_associado.Endereco.Municipio}-{_associado.Endereco.UF}");
            doc.ReplaceText("<DataCompleta>", $"{data.ToLongDateString()}");
            if (PDF)
            {
                var doctemp = $"{LocalSalvamento(pastaIndividual)}\\DocTemp.docx";
                doc.SaveAs(doctemp);
                var destino = $"{LocalSalvamento(pastaIndividual)}\\Declaracao_de_Filiacao [{_associado.Nome.ToUpper()}].pdf";
                SaidaEmPDF(doctemp, destino);
                File.Delete(doctemp);
                return destino;
            }
            else
            {
                var destino = $"{LocalSalvamento(pastaIndividual)}\\Declaracao_de_Filiacao [{_associado.Nome.ToUpper()}].docx";
                doc.SaveAs(destino);
                return destino;
            }
        }
        catch
        {
            throw;
        }
    }
    public string DeclaracaoResidencia(bool PDF, bool pastaIndividual, DateTime data)
    {
        try
        {
            var doc = DocX.Load(".\\Arquivos\\Templates\\DeclaracaoResidencia.docx");
            doc.ReplaceText("<NomeAssociado>", $"{_associado.Nome.ToUpper()}");
            doc.ReplaceText("<EstadoCivil>", $"{_associado.EstadoCivil.ToUpper()}");
            doc.ReplaceText("<CPF>", $"{_associado.GetCPF.ToUpper()}");
            doc.ReplaceText("<RG>", $"{_associado.GetRG.ToUpper()}");
            doc.ReplaceText("<EnderecoCompleto>", $"{_associado.Endereco.GetEndereco.ToUpper()}");
            doc.ReplaceText("<Municipio>", $"{_associado.Endereco.Municipio.ToUpper()}");
            doc.ReplaceText("<DataCompleta>", $"{data.ToLongDateString()}");
            if (PDF)
            {
                var doctemp = $"{LocalSalvamento(pastaIndividual)}\\DocTemp.docx";
                doc.SaveAs(doctemp);
                var destino = $"{LocalSalvamento(pastaIndividual)}\\Declaracao_de_Residencia [{_associado.Nome.ToUpper()}].pdf";
                SaidaEmPDF(doctemp, destino);
                File.Delete(doctemp);
                return destino;
            }
            else
            {
                var destino = $"{LocalSalvamento(pastaIndividual)}\\Declaracao_de_Residencia [{_associado.Nome.ToUpper()}].docx";
                doc.SaveAs(destino);
                return destino;
            }
        }
        catch(Exception ex)
        {
            throw new(ex.Message);
        }
    }

    private static string Escolha(bool o, string s)
    {
        var opcao = "  ";
        switch (s)
        {
            case "<E28A>":
            {
                if (o) opcao =  "X"; 
            }
            break;
            case "<E28B>":
            {
                if (!o) opcao = "X";
            }
            break;
            case "<E29A>":
            {
                if (o) opcao = "X";
            }
            break;
            case "<E29B>":
            {
                if (!o) opcao = "X";
            }
            break;
            case "<D25A>":
            {
                if (o) opcao = "X";
            }
            break;
            case "<D25B>":
            {
                if (o) opcao = "X";
            }
            break;
            case "<D25C>":
            {
                if (o) opcao = "X";
            }
            break;
            case "<D25D>":
            {
                if (o) opcao = "X";
            }
            break;
            case "<D25E>":
            {
                if (o) opcao = "X";
            }
            break;
            case "<G32A>":
            {
                if (o) opcao = "X";
            }
            break;
            case "<G32B>":
            {
                if (!o) opcao = "X";
            }
            break;
        }
        return opcao;
    }
    private static string Sexo(string valor, string campo)
    {
        var opcao = "  ";
        switch (valor) 
        {
            case "Masculino":
            {
                if(campo == "<A08B>") opcao = "X";
            }
            break;
            case "Feminino":
            {
                if(campo == "<A08A>") opcao = "X";
            }
            break;
        }
        return opcao;
    }
    private static string Escolaridade(string e, string o)
    {
        var opcao = "  ";
        switch (e)
        {
            case "1ª à 4ª Série incompleta/Ensino Fundamental":
                {
                    if(o == "<F30A>") opcao = "X";
                }
                break;
            case "2º Grau Completo/Ensino Médio":
                {
                    if (o == "<F30B>") opcao = "X";
                }
                break;
            case "1ª à 4ª Série completa/Ensino Fundamental":
                {
                    if (o == "<F30C>") opcao = "X";
                }
                break;
            case "Ensino Técnico Incompleto":
                {
                    if (o == "<F30D>") opcao = "X";
                }
                break;
            case "5ª à 9ª Série incompleta/Ensino Fundamental":
                {
                    if (o == "<F30E>") opcao = "X";
                }
                break;
            case "Ensino Técnico Completo":
                {
                    if (o == "<F30F>") opcao = "X";
                }
                break;
            case "5ª à 9ª Série completa/Ensino Fundamental":
                {
                    if (o == "<F30G>") opcao = "X";
                }
                break;
            case "Ensino Superior incompleto":
                {
                    if (o == "<F30H>") opcao = "X";
                }
                break;
            case "2° Grau Incompleto/Ensino Médio":
                {
                    if (o == "<F30I>") opcao = "X";
                }
                break;
            case "Ensino Superior completo":
                {
                    if (o == "<F30J>") opcao = "X";
                }
                break;
        }
        return opcao;
    }
    private static string FormaPesca(string valor, string campo)
    {
        var opcao = "  ";
        switch (valor)
        {
            case "Embarcado":
                {
                    if(campo == "<D21A>") opcao = "X";
                }
                break;
            case "Desembarcado":
                {
                    if (campo == "<D21B>") opcao = "X";
                }
                break;
        }
        return opcao;
    }
    private static string CategoriaPesca(string valor, string campo)

    {
        var selecao = "  ";
        switch (valor)
        {
            case "Artesanal":
                {
                    if(campo == "<C20A>") selecao = "X";
                }
                break;
            case "Industrial":
                {
                    if (campo == "<C20B>") selecao = "X";
                }
                break;
        }
        return selecao;
    }
    private static string DecEscolaridade(string valor, string campo)
    {
        var selecao = "  ";
        switch (valor)
        {
            case "Completamente Alfabetizado":
                {
                    if (campo == "<F31A>") selecao = "X";
                }
                break;
            case "Capaz apenas de assinar seu nome":
                {
                    if (campo == "<F31B>") selecao = "X";
                }
                break;
            case "Não alfabetizado":
                {
                    if (campo == "<F31C>") selecao = "X";
                }
                break;
        }
        return selecao;
    }

    private static string CriarPasta(string caminho)
    {
        if (!Directory.Exists(caminho)) Directory.CreateDirectory(caminho);
        return caminho;
    }
    private string LocalSalvamento(bool pastaIndividual)
    {
        if (pastaIndividual) return CriarPasta($"{_destino}\\{_associado.Nome.ToUpper()}");
        else return _destino;
    }
    private static void SaidaEmPDF(string origem, string destino)
    {
        var doc = new Document();
        doc.LoadFromFile(origem);
        doc.SaveToFile(destino, FileFormat.PDF);
    }
}