using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_3_LABORATORIO_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercucui 3: Jerarquia de operaciones");
            int num1;
            int num2;
            int num3;  
            

            Console.WriteLine("Ingrese su primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese su segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese su tercer numero");
            num3 = Convert.ToInt32(Console.ReadLine());

            int expresion1 = (num1 * num2) + num3;
            int expresion2 = num1 * (num2 + num3);

            double n1 = Convert.ToDouble(num1);
            double n2 = Convert.ToDouble(num2);
            double n3 = Convert.ToDouble(num3);

            double expresion3 = n1 / (n2 * n3);
            double expresion4 = ((3 * n1) + (2 * n2)) / (Math.Pow(n3, 2)) ;



            Console.WriteLine("("+num1 + "*" + num2 + ")" + "+"+ num3 + "=" + expresion1);
            Console.WriteLine(num1 + "*" + "("+num2 + "+" + num3+ ")" + "=" + expresion2);
            Console.WriteLine(num1 + "/" + "(" + num2 + "*" + num3 + ")" + "=" + expresion3);
            Console.WriteLine("3" + "("+  num1 + ")"+ "+" + "2"+ "(" + num2 + ")" + "/" + num3 + "^2" + "=" + expresion4);


            Console.WriteLine("Parte 2");

            double op1 = (Math.Pow(n2, 2)) - (4*(n1)*(n3));

            if(n1 != 0)
            {
                if(op1 >= 0)
                {
                    double expresion5 = (-(n2) + Math.Sqrt(op1)) / (2 * n1);
                    Console.WriteLine("X1 ="+expresion5);

                    double expresion6 = (-(n2) - Math.Sqrt(op1)) / (2 * n1);
                    Console.WriteLine("X2 = "+expresion6);

                }
                else
                {
                    Console.WriteLine("Se detecto un problema");
                }

            }
            else
            {
                Console.WriteLine("Se detecto un problema");
            }
            Console.ReadKey();




        }
    }
}
