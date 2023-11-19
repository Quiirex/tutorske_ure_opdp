namespace tutorske_ure_opdp;

/**
 * Napiši program, ki izpiše poštevanko števil do 10.
 */
public class Vaja_5
{
    public static void Izvedi()
    {
        for (var i = 1; i <= 10; i++)
        {
            for (var j = 1; j <= 10; j++) Console.Write(i * j + " ");
            Console.WriteLine();
        }
    }
}