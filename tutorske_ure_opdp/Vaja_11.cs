namespace tutorske_ure_opdp;

/**
 * Napiši program, ki prebere dve celi števili, v metodi Vmes pa izpiše vsa cela števila med njima
 */
public class Vaja_11
{
    private static void Vmes(int prvoStevilo, int drugoStevilo)
    {
        for (var i = prvoStevilo + 1; i < drugoStevilo; i++) Console.WriteLine(i);
    }

    public static void Izvedi()
    {
        Console.WriteLine("Vnesi prvo število:");
        var prvoStevilo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Vnesi drugo število:");
        var drugoStevilo = Convert.ToInt32(Console.ReadLine());
        Vmes(prvoStevilo, drugoStevilo);
    }
}