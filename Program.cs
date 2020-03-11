using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    class Program
    {
        static void Main(string[] args)
        {
            //	Instantierea unui obiect de tip Masina utilizand constructorul fara parametri
            
            var m = new Masina();
            string s = m.Info();
            Console.WriteLine(s);

            //	Instantierea unui obiect de tip Masina utilizand constructorul cu parametri
           
            Masina m1 = new Masina("VW", "negru", 4.500, 2006);
            string s1 = m1.Info();
            Console.WriteLine(s1);
            Console.ReadKey();


        }
    }
}
