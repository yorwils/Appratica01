using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appratica01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("practica1");
            Console.WriteLine((int)5.2==5);
            //primero usamos la funcionalidad int  significa numeros enteros y tambien nos da la de dicimales la que se realiza entre 5 = 5
        
            Console.WriteLine("5" + "6"=="56");
            // la condicion es de 5 + 6 nos sale 56 es verdadera
            Console.WriteLine((4 > 2) && (8 != 6) && !(5 == 6));
            //estoy declarando la regla de and y las entradas son verdad para la misma salida es verdad seria  4 >2 a la 8 diferente de 6 (verdad)
            // es esta cumple la regla de que 5 == 6 es (falcedad ) cual funcion es falso , para la realizacion de not de sus entra es falcedad
            //aplicando la misma regla y resulta ser verdadero los primeros 3 ejercicios ;
            Console.Read();

        }
    }   
}
