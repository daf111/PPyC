using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte01_Demo01
{
    class Program
    {

        static void metodo01()
        {
            Console.WriteLine("METODO 01!");
        }
        static void metodo02()
        {
            Console.WriteLine("METODO 02!");
        }

        static void Main(string[] args)
        {

            //Una forma de crear e iniciar una tarea
            Task t1 = new Task(metodo01);
            t1.Start();

            //Otra forma de crear e iniciar una tarea
            //Task t1 = Task.Factory.StartNew(metodo01);

            Task t2 = new Task(metodo02);
            t2.Start();
            //Task t2 = Task.Factory.StartNew(metodo02);

            //Espera a que todas las tareas finalicen para continuar
            //Task.WaitAll(t1,t2);

            Console.WriteLine("Finalizo proceso principal");
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadLine();
        }
    }
}
