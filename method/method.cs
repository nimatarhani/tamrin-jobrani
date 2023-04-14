using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using the_digikala.model;




namespace the_digikala.method
{
    public class method

    {
        
        List<digikala> digikalas;
        public static bool  isOdd(int id_costumer)
        {
            string address2 = @"c:\odd.text";
            if (id_costumer % 2 != 0)
                return true;
            else
                return false;
            Console.WriteLine(id_costumer);
            StreamWriter srwriter = new StreamWriter(address2);
        }
        public static bool IsPrime(int id_costumer)
        {
            string address3 = @"c:\prime.text";
            if (id_costumer <= 1)
                return false;

            for (int i = 2; i < id_costumer; i++)
            {
                if (id_costumer % i == 0)
                    return false;
            }

            return true;
            Console.WriteLine(id_costumer);
            StreamWriter srwriter = new StreamWriter(address3); 
        }
        public static bool Mirror(int id_costumer)
        {
            string address4 = @"c:\mirror.text";
            int reversedNumber = 0;
            int originalNumber = id_costumer;

            while (id_costumer > 0)
            {
                int digit = id_costumer % 10;
                reversedNumber = (reversedNumber * 10) + digit;
                id_costumer /= 10;
            }

            return originalNumber == reversedNumber;
            Console.WriteLine(id_costumer);
            StreamWriter srwriter = new StreamWriter(address4);
        }

    }
}
