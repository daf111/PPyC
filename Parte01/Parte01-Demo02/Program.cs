using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte01_Demo02
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Task t1 = Task.Factory.StartNew( () =>
            {
                Console.WriteLine("SE INICIO METODO 01");
                Console.WriteLine("METODO 01 ESTA TRABAJANDO");
                Console.WriteLine("FINALIZO METODO 01");
            });

            Task t2 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("SE INICIO METODO 02");
                Console.WriteLine("METODO 02 ESTA TRABAJANDO");
                Console.WriteLine("FINALIZO METODO 02");
            });
            
            Task.WaitAll(t1, t2);

            Console.WriteLine("Finalizó proceso principal");
            Console.ReadLine();

        }

    }
}
