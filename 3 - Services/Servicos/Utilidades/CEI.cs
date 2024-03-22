namespace Servicos.Utilidades;

public class CEI
{
    public static string FormataCEI(string CEI)
    {
        return Convert.ToUInt64(CEI).ToString(@"00\.000\.00000\/00");
    }
}
