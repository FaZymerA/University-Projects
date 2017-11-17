using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            //височина 
            int rand = random.Next(33, 188);
            Console.WriteLine("The triagle random heigh is = " + rand);
            double area = (rand * rand) * Math.PI;
            double arr = Math.Round(area, 2);
            Console.WriteLine(arr);

        }
    }
}
