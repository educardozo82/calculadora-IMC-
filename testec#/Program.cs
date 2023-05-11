using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testec_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variáveis
            float peso;
            float altura;
            float resultado;
            int idade;


            Console.WriteLine("Digite seu peso:"); // peso com ou sem casa decimal. ex 75,8 ou 75
            peso = float.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite sua altura:"); // altura com casa decimal. ex: 1,70
            altura = float.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite a su idade:");
            idade = int.Parse(Console.ReadLine());
            Console.Clear();

            resultado = peso / (altura * altura);
            Console.WriteLine("Seu IMC é: " + resultado);

            // calculo para jovens e adultos

            if (idade <= 64 && resultado <= 18.5)
            {
                Console.WriteLine("Você está abaixo do peso!");
            }
            if (idade <= 64 && resultado >= 18.6 && resultado <= 24.9)
            {
                Console.WriteLine("Seu peso está normal, parabéns!");
            }
            if (idade <= 64 && resultado >= 25 && resultado <= 29.9)
            {
                Console.WriteLine("Você está com sobrepeso!");
            }
            if (idade <= 64 && resultado >= 30 && resultado <= 34.9)
            {
                Console.WriteLine("Você está com obesidade grau 1");
                Console.WriteLine("Procure ajuda de um profissional!");
            }
            if (idade <= 64 && resultado >= 35 && resultado <= 39.9)
            {
                Console.WriteLine("Você está obesidade grau 2");
                Console.WriteLine("Procure urgente ajuda profissional!");
            }
            if (idade <= 64 && resultado >= 40)
            {
                Console.WriteLine("Você está com obesidade grau 3");
                Console.WriteLine("Procure ajuda médica urgente!");
            }

            // calculo para pessoas idosas

            if (idade >= 65 && resultado <= 22) 
            {
                Console.WriteLine("Você está abaixo do peso!");
            }
            if (idade >= 65 && resultado >= 23 && resultado <= 27)
            {
                Console.WriteLine("Seu peso está normal, parabéns!");
            }
            if (idade >= 65 && resultado >= 28)
            {
                Console.WriteLine("Você está com excesso de peso!");
            }
           

            Console.ReadLine();











        }
    }
}
