using System;

namespace _03._Point_on_Segment
{
    internal class Program
    {
        static void Main(string[] args)
        {



            var tochka1 = int.Parse(Console.ReadLine());
            var tochka2 = int.Parse(Console.ReadLine());
            var tochka3 = int.Parse(Console.ReadLine());


            var measure = 0;
            if (Math.Abs(tochka3 - tochka1) <= Math.Abs(tochka3 - tochka2))
            {
                measure = Math.Abs(tochka3 - tochka1);
            }
            else {measure = Math.Abs(tochka3 - tochka2); }
            if (tochka1 > tochka2)
            {
                var oldTochka2 = tochka2;
                tochka2 = tochka1;
                tochka1 = oldTochka2;
            }
            for (int i = tochka1; i <= tochka2; i++)
            {
                if (i == tochka3)
                {
                    Console.WriteLine("in");
                    Console.WriteLine(measure);
                    return;
                }
            }
            Console.WriteLine("out"); 
            Console.WriteLine(measure);









            //if(tochka1 > tochka2)
            //{
            //    var oldTochka2 = tochka2;
            //    tochka2 = tochka1;
            //    tochka1 = oldTochka2;
            //}
            //if(tochka3 >= tochka1 && tochka3 <= tochka2)
            //{
            //    Console.WriteLine("in");
            //    if(Math.Abs(tochka3 - tochka1) <= Math.Abs(tochka3 - tochka2))
            //    {
            //        Console.WriteLine(Math.Abs(tochka3 - tochka1));
            //    }
            //    else { Console.WriteLine(Math.Abs(tochka3 - tochka2)); }
            //}
            //else
            //{
            //    Console.WriteLine("out");
            //    if (Math.Abs(tochka3 - tochka1) <= Math.Abs(tochka3 - tochka2))
            //    {
            //        Console.WriteLine(Math.Abs(tochka3 - tochka1));
            //    }
            //    else { Console.WriteLine(Math.Abs(tochka3 - tochka2)); }
            //}

        }
    }
}
