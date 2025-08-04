using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_de_visualstudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
       

            Console.WriteLine("***CALCULO DEL SALARIO SEMANAL***");
            
            Console.WriteLine("Ingrese el costo por hora:");
            double costoPorHora = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese las horas trabajadas:");
            double horasTrabajadas = Convert.ToDouble(Console.ReadLine());
            double salarioSemanal = costoPorHora * horasTrabajadas;
            Console.WriteLine($"Su salario semanal es de: {salarioSemanal}" );
           
           
            Console.WriteLine("presione cualquier tecla`para salir");
            Console.ReadLine();
            
        }
    }
}
