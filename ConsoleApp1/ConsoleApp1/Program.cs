using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("N\t\tN*10\t\tN*100\t\tN*1000");
            for(int i = 3; i <= 7; i++)
            {


                Console.WriteLine($"{i}\t\t {i*10}\t\t{i*100}\t\t{i*1000}");

           
            }

            int counter = 3;
            int finish = 7;
            Console.WriteLine("while loop");
            while (counter <= finish)
               
            {
                
                Console.WriteLine($"{counter}\t\t{counter*10}\t\t{counter*100}\t\t{counter*1000}");
                counter++;
            }
            counter = 3;
            Console.WriteLine("Do While Loop");
            do

            {

                Console.WriteLine($"{counter}\t\t{counter * 10}\t\t{counter * 100}\t\t{counter * 1000}");
                counter++;


            } while (counter <= finish);
            {
                Console.ReadLine();

            }


        }
    }
}
