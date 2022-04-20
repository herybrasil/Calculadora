using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
     class Program
    {
        static void Main(string[] args)
        {
        
            double soma;
            double sub;
            double mult;
            double media;
    
            
     

            Console.WriteLine("----------VAMOS CALCULAR? ADIÇÃO ----------\n");


            Console.WriteLine("Digite primeiro numero: ");
            double numero1 = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Digite segundo numero: ");
            double numero2 = Convert.ToInt32(Console.ReadLine());

            soma = numero1 + numero2;
            media = (numero1 + numero2) / 2;

            Console.WriteLine("A soma dos resultados é: " + soma);
            Console.WriteLine("E a media dessa adição é: " + media);

            Console.WriteLine("----------VAMOS CALCULAR? SUBTRAÇÃO----------\n");


            Console.WriteLine("Digite primeiro numero: ");
            double numero3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite segundo numero: ");
            double numero4 = Convert.ToInt32(Console.ReadLine());

            sub = numero3 - numero4;
            media = (numero3 - numero4) / 2;

            Console.WriteLine("A soma dos resultados é: " + sub);
            Console.WriteLine("E a media dessa subtração é: " + media);


            Console.WriteLine("----------VAMOS CALCULAR? MULTIPLICAÇÃO----------\n");


            Console.WriteLine("Digite primeiro numero: ");
            double numero5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite segundo numero: ");
            double numero6 = Convert.ToInt32(Console.ReadLine());

            sub = numero5 * numero6;
            media = (numero3 * numero4) / 2;

            Console.WriteLine("A soma dos resultados é: " + sub);
            Console.WriteLine("E a media dessa multiplicação é: " + media);


            Console.ReadLine();
          
        }
    }
}
