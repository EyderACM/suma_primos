using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
   class Program
   {
      static void Main(string[] args)
      {
        int x = 2;
        int sum = 0;
        Console.WriteLine("Ingrese n");
        int n = Convert.ToInt32(Console.ReadLine());

        while(n > 1){

            if(n%x == 0){
                n = n/x;
                sum = sum + x;
            }
            else
                x = x + 1;
        }
        sum = sum  + 1;
        Console.WriteLine(sum);
      }
   }   
}

/* 
QA: Eyder A. Concha Moreno
Entradas: OK
Salidas: OK

Extra: Corregir nombrado de variables, documentación (comentarios) explicando el algoritmo
*/
