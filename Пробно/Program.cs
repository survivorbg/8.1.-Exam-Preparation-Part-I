using System;

namespace _12._Generate_Rectangles
{
    internal class Program
    {
        private static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());
            int minArea = int.Parse(Console.ReadLine());

            int count = 0;
            for (int x1Left = -n; x1Left < n; x1Left++)
               

            {
                for (int y1Top = -n; y1Top < n; y1Top++)
                   
                {
                    for (int x2Right = x1Left+1; x2Right <= n; x2Right++)
                    {
                        for (int y2Bottom = y1Top+1; y2Bottom <= n; y2Bottom++)
                        {
                            int xSide = Math.Abs(x1Left - x2Right);
                            int ySide = Math.Abs(y1Top - y2Bottom);
                            int area = ySide * xSide;
                            if (area >= minArea)
                            {
                                count++;
                                Console.WriteLine($"({x1Left}, {y1Top}) ({x2Right}, {y2Bottom}) -> {area}");
                            }
                        }
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
