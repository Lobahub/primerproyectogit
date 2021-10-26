using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calificacionfinal
{
    class Program
    {
        static void Main(string[] args)
        {
            int prac = 30;
            int teo  = 60;
            int part = 10;
            int notFin;


            Console.WriteLine(" ingrese la nota de la practica del alumno");
            prac = int.Parse(Console.ReadLine());

            Console.WriteLine(" ingrese la nota de las teoria del alumno");
            teo = int.Parse(Console.ReadLine());

            Console.WriteLine(" ingrese la nota de la participacion del alumno");
            part = int.Parse(Console.ReadLine());

         
            notFin = prac + teo + part;
            Console.WriteLine("la nota final es de: "+ notFin);


            Console.ReadKey();

        }

    }
}








