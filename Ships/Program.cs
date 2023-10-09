using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships
{
    class Program
    {
        static int[,] ships = new int[10, 10] {
        { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, },
        { 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, },
        { 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, },
        { 0, 1, 0, 1, 1, 0, 0, 1, 1, 1, },
        { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, },
        { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
        { 1, 1, 1, 1, 0, 1, 0, 0, 0, 0, },
        { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
        { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, },
        { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, }
       };

        static void Main(string[] args)
        {
            int count = CountShips();
            Console.WriteLine("Number of ships: " + count);
        }
        static int CountShips()
        {
            int count = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (ships[i, j] == 1)
                    {
                        if ((i == 0 || ships[i - 1, j] == 0) && (j == 0 || ships[i, j - 1] == 0))
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
