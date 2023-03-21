using System;

namespace _4CPerusPalkanLasku
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 3 C# Perus: Ikä-tehtävä

            //Koodi

            Console.WriteLine("Morjensta! Annappas ikäsi");
            int ika = Convert.ToInt32(Console.ReadLine()); //int.Parse(userInput); toimii myös
            int kuukaudet = ika * 12;
            Console.ReadKey();
            Console.Clear();
            Console.Write($" Olet {ika} vuotta, eli kuukausina {kuukaudet} ");

            #endregion
            #region 3 C# Perus: Palkka-tehtävä

            Console.WriteLine("MITÄ SAAT LIKSAA?");
            int liksa = Convert.ToInt32(Console.ReadLine());
            //double desimaalikorotus = Convert.ToDouble(Console.ReadLine());

            double korotus1 = liksa * 1.5;
            int korotus2 = liksa * 2;

            //VISSIIN TÄMÄ TEHTÄVÄ OLISI PITÄNYT TEHDÄ TOISIN!? :O

            Console.Write($"Saat {liksa} euroa liksaa tunnissa, eli 100% korotuksen kera se on {korotus1} ja 200% korotuksen kanssa {korotus2}");

            #endregion

        }
    }
}
