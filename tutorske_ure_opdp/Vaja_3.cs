namespace tutorske_ure_opdp;

/**
 * Napiši zanko v zanki sestavljeno iz dveh stavkov while.
 * Notranja zanka naj se izvede 4 krat.
 * Zunanja zanka naj se izvede 7 krat.
 * Notranja zanka naj izpisuje vaše ime.
 * Med imeni naj bo presledek.
 * Po vsakem prehodu zunanje zanke (ko se notranja zanka izvede 4 krat) vstavi novo vrstico.
 */
public class Vaja_3
{
    public static void Izvedi()
    {
        var outerCount = 0;
        while (outerCount < 7)
        {
            var innerCount = 0;
            while (innerCount < 4)
            {
                Console.Write("Luka ");
                innerCount++;
            }

            Console.WriteLine();
            outerCount++;
        }
    }
}