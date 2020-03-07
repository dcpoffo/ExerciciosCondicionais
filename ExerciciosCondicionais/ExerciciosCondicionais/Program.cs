using System;

namespace ExerciciosCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a sua idade: ");
            if (!Int32.TryParse(Console.ReadLine(), out int idade))
            {
                Console.WriteLine("Idade inválida");
                return;
            }
  
            ///sumary
            ///procedimento para verificar a idade
            ///
            VerificaIdade(idade);

            Console.WriteLine("*********");
            Console.WriteLine();

            Console.WriteLine("Quem ganhou a Copa do Mundo de 2014");
            Console.WriteLine("Brasil");
            Console.WriteLine("Alemanha");
            Console.WriteLine("Italia");
            Console.WriteLine("França");
            Console.WriteLine();
            string resposta = Console.ReadLine().ToUpper();

            CopaDoMundo(resposta);

            Console.WriteLine("*********");
            Console.WriteLine();

            //pegar o peso
            Console.Write("Informe o Peso: ");
            if (!double.TryParse(Console.ReadLine(), out double peso))
            {
                Console.WriteLine("Peso inválido");
                return;
            }

            //pegar a altura
            Console.Write("Informe a Altura: ");
            //decimal altura = Convert.ToDecimal(Console.ReadLine());
            if (!double.TryParse(Console.ReadLine(), out double altura))
            {
                Console.WriteLine("Altura inválida");
                return;
            }

            CalcularIMC(peso, altura);

        }

        private static void CalcularIMC(double peso, double altura)
        {
            Console.WriteLine();
            Console.WriteLine("CALCULANDO O I.M.C.: ");
            Console.WriteLine();

            //calcular o IMC
            var imc = peso / Math.Pow(2, altura); //(altura * altura);

            string classificacao = "";
            if (imc < 18.5)
            {
                classificacao = "Baixo peso";
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                classificacao = "Peso normal";
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                classificacao = "Excesso de peso";
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                classificacao = "Obesidade de classe I";
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                classificacao = "Obesidade de classe II";
            }
            else
            {
                classificacao = "Obesidade de classe III";
            }

            Console.WriteLine();
            Console.WriteLine("CALCULANDO O I.M.C. COM IF/ELSE ");

            Console.Write("Seu I.M.C. é: " + Math.Round(imc, 2) +", e sua classificação é: "+ classificacao);
            Console.WriteLine("");

            /*
            if (imc < 18.5)
            {
                Console.WriteLine("Baixo peso");
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("Excesso de peso");
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                Console.WriteLine("Obesidade de classe 1");
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                Console.WriteLine("Obesidade de classe 2");
            }
            else
            {
                Console.WriteLine("Obesidade de classe 3");
            }
            */

            Console.WriteLine();
            Console.WriteLine("CALCULANDO O I.M.C. COM SWITCH ");

            switch (imc)
            {
                case double n when (n < 18.5):
                    Console.WriteLine("Baixo peso");
                    break;
                case double n when (n >= 18.5 && n <= 24.9):
                    Console.WriteLine("Peso normal");
                    break;
                case double n when (n >= 25 && n <= 29.9):
                    Console.WriteLine("Excesso de peso");
                    break;
                case double n when (imc >= 30 && imc <= 34.9):
                    Console.WriteLine("Obesidade de classe I");
                    break;
                case double n when (imc >= 35 && imc <= 39.9):
                    Console.WriteLine("Obesidade de classe II");
                    break;
                default:
                    Console.WriteLine("Obesidade de classe III");
                    break;
            } 
        }

        private static void CopaDoMundo(string resposta)
        {
            Console.WriteLine();
            Console.WriteLine("VERIFICANDO A COPA DO MUNDO COM SWITCH");
            Console.WriteLine();

            switch (resposta)
            {
                case "BRASIL":
                    Console.WriteLine("EEEERROU!!!");
                    break;
                case "ALEMANHA":
                    Console.WriteLine("CERTA RESPOSTA!!!");
                    break;
                case "ITALIA":
                    Console.WriteLine("EEEERROU!!!");
                    break;
                case "FRANÇA":
                    Console.WriteLine("EEEERROU!!!");
                    break;
                default:
                    Console.WriteLine("Você deve escolher entre Brasil, Alemanha, Italia ou França");
                    break;
            }
        }

        private static void VerificaIdade(int idade)
        {
            Console.WriteLine();
            Console.WriteLine("VERIFICANDO A IDADE COM IF/ELSE");
            Console.WriteLine();

            if ((idade >= 13) && (idade < 19))
            {
                Console.WriteLine("ADOLESCENTE");
            }
            else if ((idade >= 19) && (idade <= 60))
            {
                Console.WriteLine("ADULTO");
            }
            else if (idade > 60)
            {
                Console.WriteLine("IDOSO");
            }
            else
            {
                Console.WriteLine("CRIANÇA");
            }
        }
    }
}
