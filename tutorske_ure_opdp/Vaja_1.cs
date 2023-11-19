namespace tutorske_ure_opdp;

/**
 * Napiši program, ki izpiše števila 20,22,24,...,200.
 * Števila naj bodo ločena z vejico in presledkom za vejico.
 * Na koncu naredi piko.
 * Nalogo reši z zanko while/do-while ali for.
 */
public class Vaja_1
{
    public static void Izvedi()
    {
        var i = 20;
        while (i <= 200)
        {
            Console.Write(i);
            Console.Write(i < 200 ? ", " : ".");
            i += 2;
        }
    }
}