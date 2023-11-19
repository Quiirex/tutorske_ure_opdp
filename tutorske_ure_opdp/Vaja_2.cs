namespace tutorske_ure_opdp;

/**
 * Napiši program, ki v zanki prebere 10 celih števil (vpiše jih uporabnik),
 * izračuna njihovo vsoto in jo izpiše.
 */
public class Vaja_2
{
    public static void Izvedi()
    {
        var sum = 0;

        for (var i = 0; i < 10; i++)
        {
            Console.Write("Vnesi število {0}: ", i + 1);
            var number = Convert.ToInt32(Console.ReadLine());
            sum += number;
        }

        Console.WriteLine("Vsota vnesenih števil je: " + sum);
    }
}