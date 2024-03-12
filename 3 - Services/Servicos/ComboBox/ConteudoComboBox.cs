using System.Numerics;

namespace Servicos.ComboBox;

public class ConteudoComboBox
{
    public static List<string> Sexo()
    {
        return new List<string>()
        {
            "Masculino",
            "Feminino"
        };
    }

    public static List<string> Estados()
    {
        return new List<string>() 
        { 
            "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", 
            "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", 
            "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"
        };
    }

    public static List<string> Escolaridade()
    {
        return new List<string>()
        {
            "1ª à 4ª Série incompleta/Ensino Fundamental",
            "2º Grau Completo/Ensino Médio",
            "1ª à 4ª Série completa/Ensino Fundamental",
            "Ensino Técnico Incompleto",
            "5ª à 9ª Série incompleta/Ensino Fundamental",
            "Ensino Técnico Completo",
            "5ª à 9ª Série completa/Ensino Fundamental",
            "Ensino Superior incompleto",
            "2° Grau Incompleto/Ensino Médio",
            "Ensino Superior completo"
        };
    }

    public static List<string> DeclaracaoEscolaridade()
    {
        return new List<string>()
        {
            "Completamente Alfabetizado",
            "Capaz apenas de assinar seu nome",
            "Não alfabetizado"
        };
    }

    public static List<string> TipoEntidade()
    {
        return new List<string>() 
        {
            "Colônia",
            "Sindicato",
            "Associação",
            "Outros"
        };
    }

    public static List<string> CategoriaProfissional()
    {
        return new List<string>() 
        {
            "Artesanal",
            "Industrial"
        };
    }

    public static List<string> FormaPesca()
    {
        return new List<string>()
        {
            "Embarcado",
            "Desembarcado"
        };
    }

    public static List<string> AreaPesca()
    {
        return new List<string>()
        {
            "Mar",
            "Estuário",
            "Rio",
            "Lago/Lagoa",
            "Reservatório",
            "Açude"
        };
    }
}