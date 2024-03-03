using System.Text.RegularExpressions;

internal class Program
{
    static void Main(string[] args)
    {
        // Teléfono
        PrintTelefono("(503) 2222-2222"); // Teléfono válido
        PrintTelefono("5032222-2222");     // Teléfono inválido

        // URL
        PrintUrl("https://www.ejemplo.com");     // URL válida
        PrintUrl("ftp://www.ejemplo.com/archivo"); // URL válida
        PrintUrl("www.ejemplo.com");             // URL inválida

        // Correo electrónico
        PrintEmail("usuario@dominio.com");    // Dirección de correo electrónico válida
        PrintEmail("usuario@dominio");        // Dirección de correo electrónico inválida

        // Código postal
        PrintPostal("01101");      // Código postal válido
        PrintPostal("0110");       // Código postal inválido

        // Fecha
        PrintFecha("12/31/2022");  // Fecha válida
        PrintFecha("31/12/2022");  // Fecha inválida
    }

    static void PrintTelefono(string telefono)
    {
        if (Regex.IsMatch(telefono, @"^\(\d{3}\) \d{4}-\d{4}$"))
        {
            Console.WriteLine("Teléfono válido.");
        }
        else
        {
            Console.WriteLine("Teléfono inválido.");
        }
    }

    static void PrintUrl(string url)
    {
        if (Regex.IsMatch(url, @"^(https?|ftp):\/\/[^\s/$.?#].[^\s]*$"))
        {
            Console.WriteLine("URL válida.");
        }
        else
        {
            Console.WriteLine("URL inválida.");
        }
    }

    static void PrintEmail(string email)
    {
        if (Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
        {
            Console.WriteLine("Dirección de correo electrónico válida.");
        }
        else
        {
            Console.WriteLine("Dirección de correo electrónico inválida.");
        }
    }

    static void PrintPostal(string codigoPostal)
    {
        if (Regex.IsMatch(codigoPostal, @"^\d{5}(?:[-\s]\d{4})?$"))
        {
            Console.WriteLine("Código postal válido.");
        }
        else
        {
            Console.WriteLine("Código postal inválido.");
        }
    }

    static void PrintFecha(string fecha)
    {
        if (Regex.IsMatch(fecha, @"^(0?[1-9]|1[0-2])\/(0?[1-9]|1\d|2\d|3[01])\/(19\d{2}|20\d{2})$"))
        {
            Console.WriteLine("Fecha válida.");
        }
        else
        {
            Console.WriteLine("Fecha inválida.");
        }
    }
}
