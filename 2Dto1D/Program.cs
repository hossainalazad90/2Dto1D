using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Dto1D
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] TwoDArray = new int[2, 3];
            Console.WriteLine("Input 2 Dimensional Array Elements below: ");
            for(int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    TwoDArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int index = 0;
            int NoOfRows = TwoDArray.GetLength(0);
            int NoOfColumns = TwoDArray.GetLength(1);
            int[] OneDArray = new int[NoOfRows * NoOfColumns];
            for (int y = 0; y < NoOfColumns; y++)
            {
                for (int x = 0; x < NoOfRows; x++)
                {
                    OneDArray[index] = TwoDArray[x, y];
                    index++;
                }
            }            
            Console.WriteLine("1 Dimensional Array Elements are: ");
            foreach (int item in OneDArray)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
