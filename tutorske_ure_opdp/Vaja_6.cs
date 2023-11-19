namespace tutorske_ure_opdp;

/**
 * Napiši program, ki izpiše trikotnik iz zvezdic velikosti 5 spodnje oblike.
 * Primer:
 * *
 * **
 * ***
 * ****
 * *****
 */
public class Vaja_6
{
    public static void Izvedi()
    {
        for (var i = 1; i <= 5; i++)
        {
            for (var j = 1; j <= i; j++) Console.Write("*");
            Console.WriteLine();
        }
    }
}