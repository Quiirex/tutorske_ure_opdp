namespace tutorske_ure_opdp;

/**
 * Napiši program, ki izpiše trikotnik iz zvezdic velikosti 5 obratne oblike kot pri nalogi 6.
 */
public class Vaja_7
{
    public static void Izvedi()
    {
        for (var i = 5; i >= 1; i--)
        {
            for (var j = 1; j <= i; j++) Console.Write("*");
            Console.WriteLine();
        }
    }
}