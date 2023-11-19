namespace tutorske_ure_opdp;

/**
 * Napiši metodo Jaz, ki trikrat izpiše vaše ime.
 * Ime loči s presledki.
 * V glavnem programu uporabi metodo tako, da bo trikrat izpisala vaše ime.
 */
public class Vaja_9
{
    private static void Jaz(string ime)
    {
        for (var i = 0; i < 3; i++) Console.Write(ime + " ");
    }

    public static void Izvedi()
    {
        Jaz("Luka");
    }
}