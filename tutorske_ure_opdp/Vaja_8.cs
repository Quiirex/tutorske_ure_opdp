namespace tutorske_ure_opdp;

/**
 * Napiši program, ki prebere celo število in ugotovi, ali je število liho ali sodo.
 * Če je liho, izpiše: "Število je liho".
 * V nasprotnem izpiše: "Število je sodo".
 * Primer 1: Vpiši število:7 Število je liho.
 * Primer 2: Vpiši število:24 Število je sodo.
 */
public class Vaja_8
{
    public static void Izvedi()
    {
        Console.Write("Vnesi število:");
        var number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(number % 2 != 0 ? "Število je liho" : "Število je sodo");
    }
}