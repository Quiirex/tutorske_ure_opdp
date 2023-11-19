namespace tutorske_ure_opdp;

/**
 * Napiši program, ki z dvema zankama izpiše kocko iz znakov 'o' veliko 5 x 5.
 */
public class Vaja_4
{
    public static void Izvedi()
    {
        for (var i = 0; i < 5; i++)
        {
            for (var j = 0; j < 5; j++) Console.Write("o");
            Console.WriteLine();
        }
    }
}