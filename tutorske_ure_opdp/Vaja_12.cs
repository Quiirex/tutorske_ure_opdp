namespace tutorske_ure_opdp;

/**
 * Napiši program, ki prebere število in ga posreduje metodi Negiraj.
 * Ta vrne njegovo negirano vrednost.
 * Preobloži metodo, da bo delovala tako za cela kot za realna števila.
 * Program naj v zanki izpisuje prvotno in negirano vrednost, dokler uporabnik to želi.
 * Preveri, kaj je negativna vrednost števila 0.
 */
public class Vaja_12
{
    private static int Negiraj(int stevilo)
    {
        return -stevilo;
    }

    private static double Negiraj(double stevilo)
    {
        return -stevilo;
    }

    public static void Izvedi()
    {
        string? odgovor;
        do
        {
            Console.WriteLine("Vnesite celo ali realno število:");
            var input = Console.ReadLine();
            if (int.TryParse(input, out var celoStevilo))
            {
                Console.WriteLine("Prvotno število: " + celoStevilo);
                Console.WriteLine("Negirano število: " + Negiraj(celoStevilo));
            }
            else if (double.TryParse(input, out var realnoStevilo))
            {
                Console.WriteLine("Prvotno število: " + realnoStevilo);
                Console.WriteLine("Negirano število: " + Negiraj(realnoStevilo));
            }

            Console.WriteLine("Ali želite nadaljevati? (da/ne)");
            odgovor = Console.ReadLine();
        } while (odgovor != null && odgovor.Equals("da", StringComparison.OrdinalIgnoreCase));
    }
}