using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte01_Demo03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 100;

            Task t1 = Task.Factory.StartNew(() =>
            {
                numero += 100;
                Console.WriteLine("SE INICIO METODO 01");
                Console.WriteLine("EL NUMERO QUE UTILIZA METODO 01 ES: " + numero.ToString());
                Console.WriteLine("FINALIZO METODO 01");
            });

            Task t2 = Task.Factory.StartNew(() =>
            {
                numero += 100;
                Console.WriteLine("SE INICIO METODO 02");
                Console.WriteLine("EL NUMERO QUE UTILIZA METODO 02 ES: " + numero.ToString());
                Console.WriteLine("FINALIZO METODO 02");
            });
            
            Task.WaitAll(t1, t2);

            Console.WriteLine("EN EL PROCESO PRINCIPAL NUMERO VALE: " + numero.ToString());
            Console.ReadLine();

        }
    }
}
