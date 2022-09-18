using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanjebr1
{
    class Program
    {
        static void Main(string[] args)
        {
            prvi: Console.WriteLine("Unesi 1. dvoznamenkasti broj");
            int prvi = Convert.ToInt32(Console.ReadLine());
            if(prvi<10 || prvi > 100)
            {
                Console.WriteLine("broj nije dvoznamenkast");
                goto prvi;
            }
            drugi: Console.WriteLine("Unesi 2. dvoznamenkasti broj");
            int drugi = Convert.ToInt32(Console.ReadLine());
            if (drugi < 10 || drugi > 100)
            {
                Console.WriteLine("broj nije dvoznamenkast");
                goto drugi;
            }
            treci: Console.WriteLine("Unesi 3. dvoznamenkasti broj");
            int treci = Convert.ToInt32(Console.ReadLine());
            if (treci < 10 || treci > 100)
            {
                Console.WriteLine("broj nije dvoznamenkast");
                goto treci;
            }

            if(prvi > drugi && prvi > treci)
            {
                Console.WriteLine("Najveci broj je {0}", prvi);
            }
            else if(drugi > treci)
            {
                Console.WriteLine("Najveci broj je {0}", drugi);
            }
            else
            {
                Console.WriteLine("Najveci broj je {0}", treci);
            }


            Console.ReadKey();
        }
    }
}
