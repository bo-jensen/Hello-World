using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImprovedRandom_API
{
    class Program
    {
        public static Random ran;

        static void Main(string[] args)
        {
            int x;

            for (int i = 0; i < 3; i++)
            {
                ExtraRan(out x, 2);

                Console.WriteLine(x);
            }

            Console.ReadKey();
        }

        public static void ExtraRan(out int improvedRandomNumber, int thoroughnessCounter)
        {
            ran = new Random(DateTime.Now.Millisecond); // !!!!!!

            int tmpRan = ran.Next();

            for (int i = 0; i < thoroughnessCounter; i++)
            {
                ran = new Random(tmpRan);

                tmpRan = ran.Next();
            }

            improvedRandomNumber = tmpRan;
        }

        //public void ExtraRan(out int improvedRandomNumber, int thoroughnessCounter, int min, int max)
        //{
        //    int tmpRan = ran.Next();

        //    for (int i = 0; i < thoroughnessCounter; i++)
        //    {
        //        tmpRan = ran.Next(tmpRan);
        //    }

        //    improvedRandomNumber = tmpRan;
        //}
    }
}
