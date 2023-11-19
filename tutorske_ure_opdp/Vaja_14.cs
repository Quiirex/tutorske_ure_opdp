namespace tutorske_ure_opdp;

/**
 * Diagram poteka pretvori v programski jezik
 */
public class Vaja_14
{
    public static void Izvedi()
    {
        var vsota = 0;
        var k = 10;

        while (k >= 1)
        {
            vsota += k;
            k -= 1;
        }

        Console.WriteLine("Vsota je: " + vsota);
    }
}