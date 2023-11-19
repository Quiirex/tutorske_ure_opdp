namespace tutorske_ure_opdp;

/**
 * Napiši metodo z imenom JazVOkvircku.
 * Metoda naj izpiše vaše ime in priimek, okoli njiju pa okvirček iz zvezdic.
 * V glavnem programu uporabi metodo v zanki, tako da po vsakem izpisu vprašaš uporabnika, ali želi še en izpis.
 */
public class Vaja_10
{
    private static void JazVOkvircku(string ime, string priimek)
    {
        var polnoIme = ime + " " + priimek;
        var zvezdice = new string('*', polnoIme.Length + 4);

        Console.WriteLine(zvezdice);
        Console.WriteLine("* " + polnoIme + " *");
        Console.WriteLine(zvezdice);
    }

    public static void Izvedi()
    {
        string odgovor;
        do
        {
            JazVOkvircku("Luka", "Mlinarič");
            Console.WriteLine("Ali želite še en izpis? (da/ne)");
            odgovor = Console.ReadLine();
        } while (odgovor != null && odgovor.Equals("da", StringComparison.OrdinalIgnoreCase));
    }
}