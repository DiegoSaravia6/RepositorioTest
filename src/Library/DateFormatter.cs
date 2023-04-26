namespace TestDateFormat;

/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{

    /// <summary>
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
    /// asumido.
    /// </summary>
    /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
    /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
    public static string ChangeFormat (string input)
    {
        if (!StringIsValid(input))
        {
            return string.Empty;
        }
        return input.Substring(6) + "-" + input.Substring(3, 2) + "-" + input.Substring(0, 2);
    }
    public static bool StringIsValid(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return false;
        } 
        else
        {
            string date;

            date = Convert.ToString(input);

            int Day = Convert.ToInt32(input.Substring(0, 2));
            int Month = Convert.ToInt32(input.Substring(3, 2));
            int Year = Convert.ToInt32(input.Substring(6));
            return (Day>=1 && Day<=31) && (Month>=1 && Month<=12) && (Year>=1 && Year <=2024);
        }
    
    }
}
