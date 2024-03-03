class Program
{
    /*
     * try-catch: En el bloque try, colocamos el código que potencialmente puede lanzar una excepción. 
     * Si se produce una excepción dentro de este bloque, se capturará en el bloque catch. 
     * La ejecución del programa continuará después del bloque catch.
     *
     * try-catch-finally: Además de los bloques try y catch, también tenemos un bloque finally. 
     * El bloque finally se ejecuta siempre, ya sea que se haya producido una excepción o no. 
     * Es útil para realizar tareas de limpieza o liberación de recursos que deben ejecutarse 
     * independientemente de si se produce una excepción o no. En el ejemplo anterior, 
     * el bloque finally se utiliza para mostrar un mensaje de salida que siempre se ejecutará 
     * al final del programa, independientemente de si se produce una excepción o no.
     */

    static void Main()
    {
        try
        {
            // Intentamos realizar una operación que puede lanzar una excepción
            int resultado = Dividir(10, 0);
            Console.WriteLine("El resultado de la división es: " + resultado);
        }
        catch (DivideByZeroException ex)
        {
            // Capturamos la excepción específica que esperábamos
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            // Esta parte se ejecutará siempre, haya o no haya ocurrido una excepción
            Console.WriteLine("Este bloque se ejecutará siempre, haya o no haya excepción.");
        }
    }

    static int Dividir(int dividendo, int divisor)
    {
        return dividendo / divisor;
    }
}
