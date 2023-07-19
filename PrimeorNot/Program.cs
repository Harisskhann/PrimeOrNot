using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeorNot
{

    class details
    {
        public int num;

        public void getdetails()
        {
            Console.Write("Enter a Number: ");
            num = Convert.ToInt32(Console.ReadLine());



        }
    }
    class prime : details
    {
        int f = 0;
        public void findprime()
        {
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    f++;
                }
            }
            if (f == 2)
            {
                Console.WriteLine("Number is Prime.");
            }
            else
            {
                Console.WriteLine("Number is Not Prime.");
            }
            Console.ReadLine();



        }

    }

    class program
    {
        static void Main(string[] args)
        {
            var prime = new prime();
            prime.getdetails();
            prime.findprime();

        }
    }

}