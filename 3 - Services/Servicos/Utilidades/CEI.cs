namespace Servicos.Utilidades;

public class CEI
{
    public static string FormataCEI(string CEI)
    {
        var CEITrimado = TrimaCEI(CEI);
        return Convert.ToUInt64(CEITrimado).ToString(@"00\.000\.00000\/00");
    }

    private static string TrimaCEI(string CEI)
    {
         return CEI.Replace(".", string.Empty).Replace("-", string.Empty).Replace("/", string.Empty);
    }
}