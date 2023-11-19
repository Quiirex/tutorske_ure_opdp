namespace tutorske_ure_opdp;

/**
 * Napiši program, ki v zanki prebere koordinati točke (x,y) in ju posreduje metodi Kvadrant, ta pa vrne številko kvadranta, v katerem se točka nahaja oz. 0, če sta vpisani koordinati koordinatno izhodišče.
 * Zanka naj se konča, ko uporabnik vnese točko (0,0).
 */
public class Vaja_13
{
    private static int Kvadrant(int x, int y)
    {
        return x switch
        {
            > 0 when y > 0 => 1,
            < 0 when y > 0 => 2,
            < 0 when y < 0 => 3,
            > 0 when y < 0 => 4,
            _ => 0
        };
    }

    public static void Izvedi()
    {
        int x, y;
        do
        {
            Console.WriteLine("Vnesite koordinato x:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vnesite koordinato y:");
            y = Convert.ToInt32(Console.ReadLine());
            var kvadrant = Kvadrant(x, y);
            if (kvadrant == 0)
                Console.WriteLine("Točka (" + x + "," + y + ") je v koordinatnem izhodišču.");
            else
                Console.WriteLine("Točka (" + x + "," + y + ") je v " + kvadrant + ". kvadrantu.");
        } while (x != 0 || y != 0);
    }
}